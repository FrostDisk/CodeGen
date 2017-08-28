using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectAccessModelController
    /// </summary>
    [Serializable]
    public class ProjectAccessModelController : ProjectPlugin
    {
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
        /// Initializes a new instance of the <see cref="ProjectAccessModelController"/> class.
        /// </summary>
        public ProjectAccessModelController()
        {
            EncryptedConnectionString = string.Empty;
            ConnectionString = string.Empty;
        }
    }
}
