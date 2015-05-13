using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    [Serializable]
    public class Plugin
    {
        [XmlAttribute("Assembly")]
        public string Assembly { get; set; }

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        [XmlAttribute("Enabled")]
        public bool Enabled { get; set; }

        [XmlAttribute("IsBase")]
        public bool IsBase { get; set; }
    }
}
