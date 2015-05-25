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

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("IsBase")]
        public bool IsBase { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

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
