using System;
using System.IO;
using System.Xml.Serialization;
using CodeGen.Configuration;
using CodeGen.Properties;
using NLog;
using NLog.Config;
using NLog.Targets;

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
            _logger.Trace("ProgramSettings.GetGlobalSettings()");

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
            catch (InvalidOperationException ex)
            {
                _logger.Error(ex, ex.Message);
                _loadedGlobalSettings = new GlobalSettings();
            }

            return _loadedGlobalSettings;
        }

        /// <summary>
        /// Saves the global configuration in a file
        /// </summary>
        public static void SaveGlobalSettings()
        {
            _logger.Trace("ProgramSettings.SaveGlobalSettings()");

            string settingsLocation = Path.Combine(SettingsFolder, Settings.Default.GlobalSettingsFilename);

            var settings = GetGlobalSettings();

            using (StreamWriter file = new StreamWriter(settingsLocation))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalSettings));

                serializer.Serialize(file, settings);
                file.Close();
            }
        }

        /// <summary>
        /// Updates the logger targets.
        /// </summary>
        public static void UpdateLoggerTargets()
        {
            var settings = GetGlobalSettings();

            var config = new LoggingConfiguration();
            var targetDefault = new FileTarget()
            {
                FileName = Path.Combine(settings.DirectoriesSettings.LogDirectory, ProgramInfo.AssemblyProduct + "_${longdate:cached=true}.log"),
                Layout = "[${longdate} (${level})] ${message}",
                ArchiveFileName = Path.Combine(settings.DirectoriesSettings.LogDirectory, ProgramInfo.AssemblyProduct + "_${shortdate}.{#}.log"),
                ArchiveAboveSize = 512 * 1024 * 10,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Rolling,
                MaxArchiveFiles = 100
            };
            var targetError = new FileTarget()
            {
                FileName = Path.Combine(settings.DirectoriesSettings.LogDirectory, ProgramInfo.AssemblyProduct + "Error_${longdate:cached=true}.log"),
                Layout = "[${longdate}] ${callsite} (${level}) ${message} ${exception:format=tostring}",
                ArchiveFileName = Path.Combine(settings.DirectoriesSettings.LogDirectory, ProgramInfo.AssemblyProduct + "Error_${shortdate}.{#}.log"),
                ArchiveAboveSize = 512 * 1024 * 10,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Rolling,
                MaxArchiveFiles = 100
            };

            config.AddTarget("logFile", targetDefault);
            config.AddTarget("logError", targetError);

            config.LoggingRules.Add(new LoggingRule("*", LogLevel.FromString(settings.LogSettings.Level), targetDefault));
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Error, targetError));

            #if DEBUG
            var targetConsole = new ConsoleTarget();
            config.AddTarget("logConsole", targetConsole);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, targetConsole));
            #endif

            LogManager.Configuration = config;
            LogManager.ReconfigExistingLoggers();
        }
    }
}
