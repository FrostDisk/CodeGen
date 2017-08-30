using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectAccessModelController
    /// </summary>
    [Serializable]
    public class ProjectController : ProjectPluginBase
    {
        /// <summary>
        /// Plugin
        /// </summary>
        [XmlAttribute("Plugin")]
        public string Plugin { get; set; }

        /// <summary>
        /// Encrypt
        /// </summary>
        [XmlAttribute("Encrypt")]
        public bool Encrypt { get; set; }

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
        /// Initializes a new instance of the <see cref="ProjectController"/> class.
        /// </summary>
        public ProjectController()
        {
            Encrypt = false;
            EncryptedConnectionString = string.Empty;
            ConnectionString = string.Empty;
        }
    }
}
