using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// Project EntityFile
    /// </summary>
    [Serializable]
    public class ProjectEntityFile
    {
        /// <summary>
        /// Guid
        /// </summary>
        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Plugin
        /// </summary>
        [XmlAttribute("Plugin")]
        public string Plugin { get; set; }

        /// <summary>
        /// Component
        /// </summary>
        [XmlAttribute("Component")]
        public int Component { get; set; }

        /// <summary>
        /// File
        /// </summary>
        [XmlText]
        public string File { get; set; }
    }
}
