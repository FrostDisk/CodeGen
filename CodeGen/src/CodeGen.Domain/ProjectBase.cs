using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Domain
{
    [XmlRoot("Project"), Serializable]
    public class ProjectBase : IProjectBase
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Version")]
        public int Version { get; set; }

        [XmlAttribute("Type")]
        public EnumDatabaseTypes Type { get; set; }

        [XmlAttribute("Source")]
        public EnumLanguages Source { get; set; }

    }
}
