﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace protozbuffer
{
    static class ProtozbuffLoader  
    {
        public static protozbuffType Load(string p)
        {
            var ser = new XmlSerializer(typeof(protozbuffType));

            var root = (protozbuffType)ser.Deserialize(File.OpenText(p));

            Check(root);
            UpdateIndexes(root);

            root.Items.OfType<messageType>().First().IsRoot = true;

            return root;
        }

        // Create a new field that contains the references to the indexed field
        private static void UpdateIndexes(protozbuffType root)
        {
            var allMessages = root.Items.OfType<messageType>().ToList();
            foreach (var msg in allMessages)
            {
                if (msg.index == null)
                    msg.index = new indexType[0];

                foreach (var index in msg.index)
                {
                    var indexedField = msg.field.Where(field => field.id == index.forField).SingleOrDefault();

                    // convert index to repeated references 
                    index.referenceField = new fieldType();
                    index.referenceField.id = index.id;
                    index.referenceField.modifier = modifierType.repeated;
                    index.referenceField.type = typeType.referenceMessage;
                    index.referenceField.messageType = indexedField.messageType;
                    index.referenceField.name = indexedField.name;

                    if (string.IsNullOrEmpty(index.name))
                    {
                        index.name = indexedField.name + "By" + index.sortBy.Capitalize();
                    }

                    var referencedFieldMessageType = allMessages.SingleOrDefault(m => m.name == index.referenceField.messageType);
                    var sortingField = referencedFieldMessageType.field.SingleOrDefault(field => field.name == index.sortBy);
                    index.sortingField = sortingField;
                }
            }
        }

        private static void Check(protozbuffType root)
        {
            var allMessages = root.Items.OfType<messageType>().ToList();

            var msgNames = new HashSet<string>();
            foreach (var msg in allMessages)
            {
                if (!msgNames.Add(msg.name))
                    Logger.Fatal("Duplicated definition for message {0}", msg.name);
            }

            foreach (var msg in allMessages)
            {
                CheckFieldsInMsg(allMessages, msg);
                CheckIndexesInMsg(allMessages, msg);
            }
        }

        private static void CheckFieldsInMsg(IEnumerable<messageType> allMessages, messageType msg)
        {
            if (msg.field == null)
                return;

            foreach (var field in msg.field)
            {
                if (field.id < 1)
                {
                    Logger.Fatal("Message {0}: field {1}'s id should be >= 1", msg.name, field.name);
                    continue;
                }

                if (field.messageType != null && allMessages.SingleOrDefault(m => m.name == field.messageType) == null)
                {
                    Logger.Fatal("Message {0}: field {1} references unknown message {2}", msg.name, field.name, field.messageType);
                    continue;
                }
            }
        }

        private static void CheckIndexesInMsg(IEnumerable<messageType> allMessages, messageType msg)
        {
            if (msg.index == null)
                return;

            foreach (var index in msg.index)
            {
                var indexedField = msg.field.Where(field => field.id == index.forField).SingleOrDefault();
                if (indexedField == null)
                {
                    Logger.Fatal("Message {0}: index {1} references unknown field {2}", msg.name, index.id, index.forField);
                    continue;
                }

                if (indexedField.modifier != modifierType.repeated)
                {
                    Logger.Fatal("Message {0}: index {1} references non repeated field {2}", msg.name, index.id, indexedField.name);
                    continue;
                }

                if (!new[] { typeType.nestedMessage, typeType.referenceMessage }.Contains(indexedField.type))
                {
                    Logger.Fatal("Message {0}: index {1} references non message field {2}", msg.name, index.id, indexedField.name);
                    continue;
                }

                // get the pointed message and check if it contains the wanted field
                var referencedFieldMessageType = allMessages.SingleOrDefault(m => m.name == indexedField.messageType);
                Debug.Assert(referencedFieldMessageType != null);

                var sortingField = referencedFieldMessageType.field.SingleOrDefault(field => field.name == index.sortBy);
                if (sortingField == null)
                {
                    Logger.Fatal("Message {0}: index {1}'s sortBy ({2}) isn't a field of message {3}", msg.name, index.id, index.sortBy, referencedFieldMessageType.name);
                    continue;
                }

                if (sortingField.modifier != modifierType.required)
                {
                    Logger.Fatal("Message {0}: index {1}'s sortBy ({2}) isn't a required field of message {3}", msg.name, index.id, index.sortBy, referencedFieldMessageType.name);
                    continue;
                }

                if (new[] { typeType.nestedMessage, typeType.referenceMessage }.Contains(sortingField.type))
                {
                    Logger.Fatal("Message {0}: index {1}'s sortBy ({2}) can't be a message", msg.name, index.id, index.sortBy);
                    continue;
                }
            }
        }
    }
}
