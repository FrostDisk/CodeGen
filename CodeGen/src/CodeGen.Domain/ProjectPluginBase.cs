using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectPlugin
    /// </summary>
    [Serializable]
    public class ProjectPluginBase
    {
        /// <summary>
        /// Guid
        /// </summary>
        [XmlAttribute("Guid")]
        public string Guid { get; set; }
    }
}
