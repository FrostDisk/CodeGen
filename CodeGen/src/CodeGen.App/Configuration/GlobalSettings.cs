using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    [Serializable]
    [XmlRoot("Settings")]
    public class GlobalSettings
    {
        [XmlElement("Project")]
        public ProjectSettings ProjectSettings { get; set; }

        public GlobalSettings()
        {
            ProjectSettings = new ProjectSettings();
        }
    }
}
