using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectBase
    /// </summary>
    [XmlRoot("Project"), Serializable]
    public class ProjectBase : IProjectBase
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
        /// Source
        /// </summary>
        [XmlAttribute("Source")]
        public EnumLanguages Source { get; set; }

    }
}
