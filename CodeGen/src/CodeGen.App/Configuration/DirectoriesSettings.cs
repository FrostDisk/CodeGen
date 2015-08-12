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
        private string _defaultProjectsDirectory;

        [XmlElement("DefaultProjectsDirectory")]
        public string DefaultProjectsDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_defaultProjectsDirectory))
                {
                    _defaultProjectsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ProgramInfo.AssemblyProduct);
                }

                if (!Directory.Exists(_defaultProjectsDirectory))
                {
                    Directory.CreateDirectory(_defaultProjectsDirectory);
                }

                return FolderHelper.PathAddBackslash(_defaultProjectsDirectory);
            }
            set { _defaultProjectsDirectory = value; }
        }

        [XmlIgnore]
        private string _pluginsDirectory;

        [XmlElement("PluginsDirectory")]
        public string PluginsDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_pluginsDirectory))
                {
                    _pluginsDirectory = Path.Combine(ProgramSettings.SettingsFolder, "Plugins");
                }

                if (!Directory.Exists(_pluginsDirectory))
                {
                    Directory.CreateDirectory(_pluginsDirectory);
                }

                return FolderHelper.PathAddBackslash(_pluginsDirectory);
            }
            set { _pluginsDirectory = value; }
        }

        [XmlIgnore]
        private string _cacheDirectory;

        [XmlElement("CacheDirectory")]
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
