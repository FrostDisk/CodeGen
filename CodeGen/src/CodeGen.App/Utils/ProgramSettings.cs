using System;
using System.IO;
using System.Xml.Serialization;
using CodeGen.Configuration;
using CodeGen.Properties;
using NLog;

namespace CodeGen.Utils
{
    /// <summary>
    /// Static Class to store global configuration 
    /// </summary>
    public static class ProgramSettings
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        internal static string SettingsFolder
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProgramInfo.AssemblyCompany, ProgramInfo.AssemblyProduct); }
        }

        private static GlobalSettings _loadedGlobalSettings;

        /// <summary>
        /// Load the global configuration settings for the application instance
        /// </summary>
        /// <returns></returns>
        public static GlobalSettings GetGlobalSettings()
        {
            if (_loadedGlobalSettings != null)
            {
                return _loadedGlobalSettings;
            }

            // look-up for the global settings folder, inside /User/Local
            if (!Directory.Exists(SettingsFolder))
            {
                Directory.CreateDirectory(SettingsFolder);
                _loadedGlobalSettings = new GlobalSettings();
                return _loadedGlobalSettings;
            }

            // look-up the settings file
            string settingsLocation = Path.Combine(SettingsFolder, Settings.Default.GlobalSettingsFilename);
            if (!File.Exists(settingsLocation))
            {
                _loadedGlobalSettings = new GlobalSettings();
                return _loadedGlobalSettings;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (GlobalSettings));

                using (StreamReader reader = new StreamReader(settingsLocation))
                {
                    _loadedGlobalSettings = serializer.Deserialize(reader) as GlobalSettings;
                    reader.Close();
                }
            }
            catch (InvalidOperationException)
            {
                _loadedGlobalSettings = new GlobalSettings();
            }

            return _loadedGlobalSettings;
        }

        /// <summary>
        /// Saves the global configuration in a file
        /// </summary>
        public static void SaveGlobalSettings()
        {
            string settingsLocation = Path.Combine(SettingsFolder, Settings.Default.GlobalSettingsFilename);

            var settings = GetGlobalSettings();

            using (StreamWriter file = new StreamWriter(settingsLocation))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalSettings));

                serializer.Serialize(file, settings);
                file.Close();
            }
        }
    }
}
