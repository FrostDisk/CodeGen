using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    [Serializable]
    public class PluginAssembly
    {
        [XmlAttribute("File")]
        public string File { get; set; }

        [XmlAttribute("Title")]
        public string Title { get; set; }

        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("IsBase")]
        public bool IsBase { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Author")]
        public string Author { get; set; }

        [XmlElement("Url")]
        public string Url { get; set; }

        [XmlArray("Components"), XmlArrayItem("Type")]
        public List<PluginType> Types { get; set; }

        [XmlIgnore]
        public Assembly AssemblyInstance { get; set; }

        [XmlIgnore]
        public bool IsLoaded { get; set; }

        public PluginAssembly()
        {
            Types = new List<PluginType>();
            IsLoaded = false;
        }
    }
}
