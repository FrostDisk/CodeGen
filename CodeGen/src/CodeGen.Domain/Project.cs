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
        /// AccessModel
        /// </summary>
        [XmlElement("Controller")]
        public ProjectController Controller { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Plugins
        /// </summary>
        [XmlArray("Entities"), XmlArrayItem("Entity")]
        public List<ProjectEntity> Entities { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [XmlElement("Properties")]
        public ProjectProperties Properties { get; set; }

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
        public const int ActiveVersion = 2;

        /// <summary>
        /// Project
        /// </summary>
        public Project()
        {
            Name = string.Empty;
            Version = 0;
            Type = EnumDatabaseTypes.SqlServer;
            Controller = new ProjectController();
            Description = string.Empty;
            Entities = new List<ProjectEntity>();
            //Properties = new ProjectProperties();
            SaveLocation = string.Empty;
            SaveDirectory = string.Empty;
            IsNew = true;
            IsUnsaved = true;
        }
    }
}
