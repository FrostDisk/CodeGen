using System;
using System.Xml.Serialization;
using CodeGen.Properties;

namespace CodeGen.Configuration
{
    /// <summary>
    /// ProjectSettings
    /// </summary>
    [Serializable]
    public class ProjectSettings
    {
        [XmlIgnore]
        private string _defaultProjectName;

        /// <summary>
        /// Gets the default name of the project.
        /// </summary>
        [XmlElement("DefaultProjectName")]
        public string DefaultProjectName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultProjectName))
                {
                    _defaultProjectName = Settings.Default.DefaultProjectName;
                }
                return _defaultProjectName;
            }
        }
    }
}
