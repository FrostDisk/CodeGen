using System;
using System.Xml.Serialization;
using CodeGen.Properties;

namespace CodeGen.Configuration
{
    [Serializable]
    public class ProjectSettings
    {
        [XmlIgnore]
        public string _defaultProjectName;

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
