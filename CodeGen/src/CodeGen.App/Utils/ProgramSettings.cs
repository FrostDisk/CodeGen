using System;
using System.IO;
using System.Xml.Serialization;
using CodeGen.Configuration;
using CodeGen.Properties;

namespace CodeGen.Utils
{
    public static class ProgramSettings
    {
        internal static string SettingsFolder
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProgramInfo.AssemblyCompany, ProgramInfo.AssemblyProduct); }
        }

        private static GlobalSettings _loadedGlobalSettings;

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
