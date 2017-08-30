using CodeGen.Utils;
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
        /// Version
        /// </summary>
        [XmlAttribute("Version")]
        public string Version { get; set; }

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
        [XmlArray("Assemblies"), XmlArrayItem("Assembly")]
        public GlobalAssemblies Assemblies { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSettings"/> class.
        /// </summary>
        public GlobalSettings()
        {
            Version = ProgramInfo.AssemblyVersion;
            DirectoriesSettings = new DirectoriesSettings();
            LogSettings = new LogSettings();
            ProjectSettings = new ProjectSettings();
            Assemblies = new GlobalAssemblies();
        }
    }
}
