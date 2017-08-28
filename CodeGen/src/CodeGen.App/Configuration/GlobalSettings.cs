using System;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    /// <summary>
    /// GlobalSettings
    /// </summary>
    [Serializable]
    [XmlRoot("Settings")]
    public class GlobalSettings
    {
        /// <summary>
        /// DirectoriesSettings
        /// </summary>
        [XmlElement("Directories")]
        public DirectoriesSettings DirectoriesSettings { get; set; }

        /// <summary>
        /// LogSettings
        /// </summary>
        [XmlElement("Log")]
        public LogSettings LogSettings { get; set; }

        /// <summary>
        /// Gets or sets the project settings.
        /// </summary>
        [XmlElement("Project")]
        public ProjectSettings ProjectSettings { get; set; }

        /// <summary>
        /// Gets or sets the plugins settings.
        /// </summary>
        [XmlElement("Plugins")]
        public PluginsSettings PluginsSettings { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSettings"/> class.
        /// </summary>
        public GlobalSettings()
        {
            DirectoriesSettings = new DirectoriesSettings();
            LogSettings = new LogSettings();
            ProjectSettings = new ProjectSettings();
            PluginsSettings = new PluginsSettings();
        }
    }
}
