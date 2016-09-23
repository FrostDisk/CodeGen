using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectPlugin
    /// </summary>
    [Serializable]
    public class ProjectPlugin
    {
        /// <summary>
        /// Guid
        /// </summary>
        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [XmlAttribute("Type")]
        public string Type { get; set; }
    }
}
