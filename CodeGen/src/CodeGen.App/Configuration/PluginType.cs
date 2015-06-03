using System;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;

namespace CodeGen.Configuration
{
    [Serializable]
    public class PluginType
    {
        [XmlAttribute("Class")]
        public string Class { get; set; }

        [XmlAttribute("Base")]
        public string Base { get; set; }

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        [XmlAttribute("Enabled")]
        public bool Enabled { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

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
