using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// PluginParameter
    /// </summary>
    [Serializable]
    public class PluginParameter
    {
        /// <summary>
        /// Code
        /// </summary>
        [XmlAttribute("Code")]
        public string Code { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        /// <summary>
        /// TypeName
        /// </summary>
        [XmlAttribute("Type")]
        public string TypeName
        {
            get { return Type != null ? Type.ToString() : null; }
            set { Type = Type.GetType(value); }
        }

        /// <summary>
        /// Type
        /// </summary>
        [XmlIgnore]
        public Type Type { get; set; }

        /// <summary>
        /// UseDefault
        /// </summary>
        [XmlAttribute("UseDefault")]
        public bool UseDefault { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}={1}{2}", Code, Value, UseDefault ? " (default)" : string.Empty);
        }
    }
}
