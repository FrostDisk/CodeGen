using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Plugin.Base
{
    [Serializable]
    public class PluginSettingValue
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("UseDefault")]
        public bool UseDefault { get; set; }
    }
}
