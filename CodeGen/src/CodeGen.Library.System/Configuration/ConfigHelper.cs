using System;
using System.Configuration;

namespace CodeGen.Library.System.Configuration
{
    /// <summary>
    /// Static class to access configuration files for application
    /// </summary>
    public static class ConfigHelper
    {
        /// <summary>
        /// Get value from a application settings from a key
        /// </summary>
        /// <param name="key">unique key to identify the setting</param>
        /// <param name="throwException">Throw exception if the value doesn't exist in the configuration file. If <c>false</c> this method will only return the default value</param>
        /// <param name="defaultValue">Default value if the setting value doesn't exist in the configuration file.</param>
        /// <returns></returns>
        public static string GetValueWebConfig(string key, bool throwException = true, string defaultValue = "")
        {
            return GetValueAppConfig(key, throwException, defaultValue);
        }

        /// <summary>
        /// Get value from a application settings from a key
        /// </summary>
        /// <param name="key">unique key to identify the setting</param>
        /// <param name="throwException">Throw exception if the value doesn't exist in the configuration file. If <c>false</c> this method will only return the default value</param>
        /// <param name="defaultValue">Default value if the setting value doesn't exist in the configuration file.</param>
        /// <returns></returns>
        public static string GetValueAppConfig(string key, bool throwException = true, string defaultValue = "")
        {
            string valor = ConfigurationManager.AppSettings.Get(key);

            if (string.IsNullOrWhiteSpace(valor))
            {
                if (throwException)
                {
                    throw new NullReferenceException("The application configuration file doesn't have a value with the key '" + key + "'");
                }
                if (!string.IsNullOrWhiteSpace(defaultValue))
                {
                    ConfigurationManager.AppSettings.Set(key, defaultValue);
                    return defaultValue;
                }
                return string.Empty;
            }

            return valor;
        }

        /// <summary>
        /// Get the connection string from the configuration file
        /// </summary>
        /// <param name="connectionStringKey">Unique key to identify the connection string</param>
        /// <returns></returns>
        public static string GetConnectionString(string connectionStringKey)
        {
            ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey];

            if (connectionString == null || string.IsNullOrWhiteSpace(connectionString.ConnectionString))
            {
                throw new NullReferenceException("The application configuration file doesn't have a connection string with the key '" + connectionStringKey + "'");
            }

            return connectionString.ConnectionString;
        }

        /// <summary>
        /// Refresh the values from the appSettings section in the configuration file
        /// </summary>
        public static void RefreshAppSettingsSection()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Refresh the values from the connectionStrings section in the configuration file
        /// </summary>
        public static void RefreshConnectionStringsSection()
        {
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
