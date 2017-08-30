using System;
using System.IO;
using System.Xml.Serialization;
using CodeGen.Library.System.IO;
using CodeGen.Utils;

namespace CodeGen.Configuration
{
    /// <summary>
    /// Directories Settings 
    /// </summary>
    [Serializable]
    public class DirectoriesSettings
    {
        [XmlIgnore]
        private string _defaultProjectsDirectory;

        /// <summary>
        /// Default Projects Directory
        /// </summary>
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

        /// <summary>
        /// Plugins Directory
        /// </summary>
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

        /// <summary>
        /// Cache Directory
        /// </summary>
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

        /// <summary>
        /// Temp Directory
        /// </summary>
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

        [XmlIgnore]
        private string _logDirectory;

        /// <summary>
        /// Temp Directory
        /// </summary>
        [XmlElement("LogDirectory")]
        public string LogDirectory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_logDirectory))
                {
                    _logDirectory = Path.Combine(ProgramSettings.SettingsFolder, "Log");
                }

                if (!Directory.Exists(_logDirectory))
                {
                    Directory.CreateDirectory(_logDirectory);
                }

                return FolderHelper.PathAddBackslash(_logDirectory);
            }
            set { _logDirectory = value; }
        }
    }
}
