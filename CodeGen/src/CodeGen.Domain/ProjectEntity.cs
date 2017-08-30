using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectEntity
    /// </summary>
    [Serializable]
    public class ProjectEntity
    {
        /// <summary>
        /// TableName
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [XmlElement("File")]
        public List<ProjectEntityFile> Files { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectEntity"/> class.
        /// </summary>
        public ProjectEntity()
        {
            Files = new List<ProjectEntityFile>();
        }
    }
}
