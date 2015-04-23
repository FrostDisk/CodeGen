using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [XmlRoot("Project"), Serializable]
    public class Project
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Version")]
        public int Version { get; set; }

        [XmlAttribute("Type")]
        public ServerType Type { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ConnectionString")]
        public string ConnectionString { get; set; }

        [XmlArray("Properties"), XmlArrayItem("Property")]
        public List<ProjectProperty> Properties { get; set; }

        [XmlArray("Entities"), XmlArrayItem("Entity")]
        public List<ProjectEntity> Entities { get; set; }

        [XmlIgnore]
        public string SaveLocation { get; set; }

        [XmlIgnore]
        public bool IsNew { get; set; }

        [XmlIgnore]
        public bool IsUnsaved { get; set; }

        public Project()
        {
            Name = string.Empty;
            Version = 0;
            Type = ServerType.SqlServer;
            Description = string.Empty;
            ConnectionString = string.Empty;
            Properties = new List<ProjectProperty>();
            Entities = new List<ProjectEntity>();
            SaveLocation = string.Empty;
            IsNew = true;
            IsUnsaved = true;
        }
    }
}
