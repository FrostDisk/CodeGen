using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Properties;
using CodeGen.Utils;

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
