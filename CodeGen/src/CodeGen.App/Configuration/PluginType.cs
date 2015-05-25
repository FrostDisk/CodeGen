using System;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;

namespace CodeGen.Configuration
{
    [Serializable]
    public class PluginType
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        [XmlAttribute("Enabled")]
        public bool Enabled { get; set; }

        [XmlIgnore]
        public IPluginBase PluginInstance { get; set; }

        [XmlIgnore]
        public bool IsLoaded { get; set; }

        public PluginType()
        {
            IsLoaded = false;
        }
    }
}
