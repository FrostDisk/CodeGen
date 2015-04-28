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
        private string _defaultProjectLocation;

        [XmlElement("DefaultProjectLocation")]
        public string DefaultProjectLocation
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultProjectLocation))
                {
                    _defaultProjectLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ProgramInfo.AssemblyProduct);
                }

                if (!Directory.Exists(_defaultProjectLocation))
                {
                    Directory.CreateDirectory(_defaultProjectLocation);
                }

                return _defaultProjectLocation;;
            }
            set { _defaultProjectLocation = value; }
        }

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
