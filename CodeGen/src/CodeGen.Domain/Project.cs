using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// Project
    /// </summary>
    [XmlRoot("Project"), Serializable]
    public class Project : IProjectBase
    {
        /// <summary>
        /// Name
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [XmlAttribute("Version")]
        public int Version { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [XmlAttribute("Type")]
        public EnumDatabaseTypes Type { get; set; }

        /// <summary>
        /// Plugin
        /// </summary>
        [XmlElement("Plugin")]
        public ProjectPlugin Plugin { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// EncryptedConnectionString
        /// </summary>
        [XmlElement("ConnectionString")]
        public string EncryptedConnectionString { get; set; }

        /// <summary>
        /// ConnectionString
        /// </summary>
        [XmlIgnore]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [XmlElement("Properties")]
        public ProjectProperties Properties { get; set; }

        /// <summary>
        /// Entities
        /// </summary>
        [XmlArray("Entities"), XmlArrayItem("Entity")]
        public List<ProjectEntity> Entities { get; set; }

        /// <summary>
        /// SaveLocation
        /// </summary>
        [XmlIgnore]
        public string SaveLocation { get; set; }

        /// <summary>
        /// SaveDirectory
        /// </summary>
        [XmlIgnore]
        public string SaveDirectory { get; set; }

        /// <summary>
        /// IsNew
        /// </summary>
        [XmlIgnore]
        public bool IsNew { get; set; }

        /// <summary>
        /// IsUnsaved
        /// </summary>
        [XmlIgnore]
        public bool IsUnsaved { get; set; }

        /// <summary>
        /// IsValid
        /// </summary>
        [XmlIgnore]
        public bool IsValid { get; set; }

        /// <summary>
        /// ActiveVersion
        /// </summary>
        [XmlIgnore]
        public const int ActiveVersion = 1;

        /// <summary>
        /// Project
        /// </summary>
        public Project()
        {
            Name = string.Empty;
            Version = 0;
            Type = EnumDatabaseTypes.SqlServer;
            Description = string.Empty;
            EncryptedConnectionString = string.Empty;
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
