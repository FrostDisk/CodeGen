using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [XmlRoot("Project"), Serializable]
    public class Project : IProjectBase
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Version")]
        public int Version { get; set; }

        [XmlAttribute("Type")]
        public EnumDatabaseTypes Type { get; set; }

        [XmlElement("Plugin")]
        public ProjectPlugin Plugin { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ConnectionString")]
        public string ConnectionString { get; set; }

        [XmlElement("Properties")]
        public ProjectProperties Properties { get; set; }

        [XmlArray("Entities"), XmlArrayItem("Entity")]
        public List<ProjectEntity> Entities { get; set; }

        [XmlIgnore]
        public string SaveLocation { get; set; }

        [XmlIgnore]
        public string SaveDirectory { get; set; }

        [XmlIgnore]
        public bool IsNew { get; set; }

        [XmlIgnore]
        public bool IsUnsaved { get; set; }

        [XmlIgnore]
        public bool IsValid { get; set; }

        [XmlIgnore]
        public const int ActiveVersion = 1;

        public Project()
        {
            Name = string.Empty;
            Version = 0;
            Type = EnumDatabaseTypes.SqlServer;
            Description = string.Empty;
            ConnectionString = string.Empty;
            //Properties = new ProjectProperties();
            //Entities = new List<ProjectEntity>();
            SaveLocation = string.Empty;
            SaveDirectory = string.Empty;
            IsNew = true;
            IsUnsaved = true;
        }
    }
}
