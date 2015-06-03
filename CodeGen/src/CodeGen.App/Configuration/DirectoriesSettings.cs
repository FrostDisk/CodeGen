using System;
using System.IO;
using System.Xml.Serialization;
using CodeGen.Library.System.IO;
using CodeGen.Utils;

namespace CodeGen.Configuration
{
    [Serializable]
    public class DirectoriesSettings
    {
        [XmlIgnore]
        private string _defaultProjectDirectory;

        [XmlElement("DefaultProjectDirectory")]
        public string DefaultProjectDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultProjectDirectory))
                {
                    _defaultProjectDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ProgramInfo.AssemblyProduct);
                }

                if (!Directory.Exists(_defaultProjectDirectory))
                {
                    Directory.CreateDirectory(_defaultProjectDirectory);
                }

                return FolderHelper.PathAddBackslash(_defaultProjectDirectory);
            }
            set { _defaultProjectDirectory = value; }
        }

        [XmlIgnore]
        private string _defaultPluginsDirectory;

        [XmlElement("DefaultPluginsDirectory")]
        public string DefaultPluginsDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultPluginsDirectory))
                {
                    _defaultPluginsDirectory = Path.Combine(ProgramSettings.SettingsFolder, "Plugins");
                }

                if (!Directory.Exists(_defaultPluginsDirectory))
                {
                    Directory.CreateDirectory(_defaultPluginsDirectory);
                }

                return FolderHelper.PathAddBackslash(_defaultPluginsDirectory);
            }
            set { _defaultPluginsDirectory = value; }
        }

        [XmlIgnore]
        private string _cacheDirectory;

        [XmlElement("CacheLocation")]
        public string CacheDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_cacheDirectory))
                {
                    _cacheDirectory = Path.Combine(ProgramSettings.SettingsFolder, "Cache");
                }

                if (!Directory.Exists(_cacheDirectory))
                {
                    Directory.CreateDirectory(_cacheDirectory);
                }

                return FolderHelper.PathAddBackslash(_cacheDirectory);
            }
            set { _cacheDirectory = value; }
        }

        [XmlIgnore]
        private string _tempDirectory;

        [XmlElement("TempDirectory")]
        public string TempDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_tempDirectory))
                {
                    _tempDirectory = Path.Combine(ProgramSettings.SettingsFolder, "Temp");
                }

                if (!Directory.Exists(_tempDirectory))
                {
                    Directory.CreateDirectory(_tempDirectory);
                }

                return FolderHelper.PathAddBackslash(_tempDirectory);
            }
            set { _tempDirectory = value; }
        }
    }
}
