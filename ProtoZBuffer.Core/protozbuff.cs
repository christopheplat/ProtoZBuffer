﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 

using System.Xml.Serialization;

namespace ProtoZBuffer.Core {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    [XmlRoot("protozbuff", Namespace="http://tempuri.org/protoZ.xsd", IsNullable=false)]
    public partial class protozbuffType {
        
        private object[] itemsField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlElement("enum", typeof(enumType))]
        [XmlElement("message", typeof(messageType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public partial class enumType {
        
        private enumElementType[] enumItemField;
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlElement("enumItem")]
        public enumElementType[] enumItem {
            get {
                return this.enumItemField;
            }
            set {
                this.enumItemField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public partial class enumElementType {
        
        private string nameField;
        
        private string valueField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public partial class indexType {
        
        private int idField;
        
        private string nameField;
        
        private int forFieldField;
        
        private string sortByField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public int forField {
            get {
                return this.forFieldField;
            }
            set {
                this.forFieldField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string sortBy {
            get {
                return this.sortByField;
            }
            set {
                this.sortByField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public partial class fieldType {
        
        private int idField;
        
        private string nameField;
        
        private typeType typeField;
        
        private string messageTypeField;
        
        private string enumTypeField;
        
        private modifierType modifierField;
        
        private string defaultField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public typeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string enumType {
            get {
                return this.enumTypeField;
            }
            set {
                this.enumTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public modifierType modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public enum typeType {
        
        /// <remarks/>
        @double,
        
        /// <remarks/>
        @float,
        
        /// <remarks/>
        int32,
        
        /// <remarks/>
        int64,
        
        /// <remarks/>
        uint32,
        
        /// <remarks/>
        uint64,
        
        /// <remarks/>
        sint32,
        
        /// <remarks/>
        sint64,
        
        /// <remarks/>
        fixed32,
        
        /// <remarks/>
        fixed64,
        
        /// <remarks/>
        sfixed32,
        
        /// <remarks/>
        sfixed64,
        
        /// <remarks/>
        @bool,
        
        /// <remarks/>
        @string,
        
        /// <remarks/>
        bytes,
        
        /// <remarks/>
        referenceMessage,
        
        /// <remarks/>
        nestedMessage,
        
        /// <remarks/>
        @enum,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public enum modifierType {
        
        /// <remarks/>
        required,
        
        /// <remarks/>
        optional,
        
        /// <remarks/>
        repeated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace="http://tempuri.org/protoZ.xsd")]
    public partial class messageType {
        
        private fieldType[] fieldField;
        
        private indexType[] indexField;
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlElement("field")]
        public fieldType[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("index")]
        public indexType[] index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
}
