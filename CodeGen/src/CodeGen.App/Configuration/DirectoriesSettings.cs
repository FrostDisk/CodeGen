using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Utils;

namespace CodeGen.Configuration
{
    [Serializable]
    public class DirectoriesSettings
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

                return _defaultProjectLocation; ;
            }
            set { _defaultProjectLocation = value; }
        }

        [XmlIgnore]
        private string _defaultPluginsLocation;

        [XmlElement("DefaultPluginsLocation")]
        public string DefaultPluginsLocation
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultPluginsLocation))
                {
                    _defaultPluginsLocation = Path.Combine(ProgramSettings.SettingsFolder, "Plugins");
                }

                if (!Directory.Exists(_defaultPluginsLocation))
                {
                    Directory.CreateDirectory(_defaultPluginsLocation);
                }

                return _defaultPluginsLocation; ;
            }
            set { _defaultPluginsLocation = value; }
        }
    }
}
