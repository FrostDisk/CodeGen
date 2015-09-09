using System;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    [Serializable]
    [XmlRoot("Settings")]
    public class GlobalSettings
    {
        [XmlElement("Directories")]
        public DirectoriesSettings DirectoriesSettings { get; set; }

        [XmlElement("Project")]
        public ProjectSettings ProjectSettings { get; set; }

        [XmlElement("Plugins")]
        public PluginsSettings PluginsSettings { get; set; }

        public GlobalSettings()
        {
            DirectoriesSettings = new DirectoriesSettings();
            ProjectSettings = new ProjectSettings();
            PluginsSettings = new PluginsSettings();
        }
    }
}
