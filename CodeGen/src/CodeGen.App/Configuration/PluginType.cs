using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
    }
}
