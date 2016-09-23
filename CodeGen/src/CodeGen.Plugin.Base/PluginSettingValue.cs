using System;
using System.Xml.Serialization;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// PluginSettingValue
    /// </summary>
    [Serializable]
    public class PluginSettingValue
    {
        /// <summary>
        /// Key
        /// </summary>
        [XmlAttribute("Key")]
        public string Key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [XmlAttribute("Type")]
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
            return string.Format("{0}=\"{1}\"{2}", Key, Value, UseDefault ? " (default)" : string.Empty);
        }
    }
}
