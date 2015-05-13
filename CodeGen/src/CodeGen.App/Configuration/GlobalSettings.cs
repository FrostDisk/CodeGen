using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Utils;

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
