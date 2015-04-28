using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Configuration;
using CodeGen.Properties;

namespace CodeGen.Utils
{
    public static class ProgramSettings
    {
        private static GlobalSettings _loadedGlobalSettings;

        public static GlobalSettings GetGlobalSettings()
        {
            if (_loadedGlobalSettings != null)
            {
                return _loadedGlobalSettings;
            }

            // look-up for the global settings folder, inside /User/Local
            string settingsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProgramInfo.AssemblyCompany, ProgramInfo.AssemblyProduct);
            if (!Directory.Exists(settingsFolder))
            {
                Directory.CreateDirectory(settingsFolder);
                _loadedGlobalSettings = new GlobalSettings();
                return _loadedGlobalSettings;
            }

            // look-up the settings file
            string settingsLocation = Path.Combine(settingsFolder, Settings.Default.GlobalSettingsFilename);
            if (!File.Exists(settingsFolder))
            {
                _loadedGlobalSettings = new GlobalSettings();
                return _loadedGlobalSettings;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(GlobalSettings));

            using (StreamReader reader = new StreamReader(settingsLocation))
            {
                _loadedGlobalSettings = serializer.Deserialize(reader) as GlobalSettings;
                reader.Close();
            }

            return _loadedGlobalSettings;
        }
    }
}
