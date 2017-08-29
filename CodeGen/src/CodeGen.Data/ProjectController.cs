using CodeGen.Domain;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;
using CodeGen.Library.Security;
using CodeGen.Library.Formats;
using System.Runtime.InteropServices;
using NLog;
using System;

namespace CodeGen.Data
{
    /// <summary>
    /// ProjectController
    /// </summary>
    public static class ProjectController
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Creates the empty project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="projectDirectory">The project directory.</param>
        /// <returns></returns>
        public static Project CreateEmptyProject(string projectName, string projectDirectory)
        {
            _logger.Trace("ProjectController.CreateEmptyProject()");

            string safeProjectName = StringHelper.ConvertToSafeFileName(projectName);

            Project project = new Project();
            project.Name = projectName;
            project.Version = Project.ActiveVersion;
            project.SaveLocation = Path.Combine(projectDirectory, string.Format("{0}.cgproj", safeProjectName.ToLower()));
            project.SaveDirectory = projectDirectory;
            project.IsNew = true;
            project.IsUnsaved = true;
            project.IsValid = true;

            return project;
        }


        /// <summary>
        /// Saves the project to stream.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="projectStream">The project stream.</param>
        /// <param name="encryptionKey">The encryption key.</param>
        public static void SaveProjectToStream(Project project, Stream projectStream, string encryptionKey)
        {
            _logger.Trace("ProjectController.SaveProjectToStream()");

            // Encrypt Connection String
            project.Controller.EncryptedConnectionString = project.Controller.Encrypt
                                                                ? StringEncryptorHelper.Encrypt(project.Controller.ConnectionString, encryptionKey)
                                                                : project.Controller.ConnectionString;

            using (StreamWriter streamWriter = new StreamWriter(projectStream, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Project));

                serializer.Serialize(streamWriter, project);
            }

            project.IsNew = false;
            project.IsUnsaved = false;
        }

        /// <summary>
        /// Opens the project from location.
        /// </summary>
        /// <param name="projectLocation">The project location.</param>
        /// <param name="decryptionKey">The decryption key.</param>
        /// <returns></returns>
        public static Project OpenProjectFromLocation(string projectLocation, string decryptionKey)
        {
            _logger.Trace("ProjectController.OpenProjectFromLocation()");

            using (StreamReader streamReader = new StreamReader(projectLocation, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Project));

                Project project = (Project)serializer.Deserialize(streamReader);

                if (project != null)
                {
                    project.SaveLocation = projectLocation;
                    project.SaveDirectory = Path.GetDirectoryName(projectLocation);
                    return RecalculateVariables(project, decryptionKey);
                }
            }

            return new Project();
        }

        /// <summary>
        /// Gets the plugin properties.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="guid">The assembly file.</param>
        /// <param name="plugin">The plugin.</param>
        /// <returns></returns>
        public static ProjectPluginProperties GetPluginProperties(Project project, string guid)
        {
            _logger.Trace("ProjectController.GetPluginProperties()");

            if (project.Properties == null
                || project.Properties.Plugins == null)
            {
                return null;
            }

            return project.Properties.Plugins.FirstOrDefault(p => p.Guid.Equals(guid, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Updates the plugin settings.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="plugin">The plugin.</param>
        /// <returns></returns>
        public static Project UpdatePluginSettings(Project project, IGeneratorTemplate plugin)
        {
            _logger.Trace("ProjectController.UpdatePluginSettings()");

            if (project.Properties == null)
            {
                project.Properties = new ProjectProperties();
            }

            if (project.Properties.Plugins == null)
            {
                project.Properties.Plugins = new List<ProjectPluginProperties>();
            }

            var type = plugin.GetType();
            string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

            var pluginAssembly = project.Properties.Plugins.FirstOrDefault(p => p.Guid.Equals(guid, StringComparison.InvariantCultureIgnoreCase));
            if (pluginAssembly == null)
            {
                pluginAssembly = new ProjectPluginProperties();
                pluginAssembly.Guid = guid;
                project.Properties.Plugins.Add(pluginAssembly);
            }

            if (pluginAssembly.Parameters == null)
            {
                pluginAssembly.Parameters = new List<PluginParameter>();
            }

            // Remove all default values from plugin parameters
            pluginAssembly.Parameters.RemoveAll(p => plugin.Settings.Any(s => s.Key.Equals(p.Code, StringComparison.InvariantCultureIgnoreCase) && s.UseDefault));

            // Check all non-default parameters
            foreach (PluginSettingValue settingValue in plugin.Settings.Where(s => !s.UseDefault))
            {
                var parameter = pluginAssembly.Parameters.FirstOrDefault(c => c.Code.Equals(settingValue.Key, StringComparison.InvariantCultureIgnoreCase));
                if (parameter == null)
                {
                    parameter = new PluginParameter();
                    pluginAssembly.Parameters.Add(parameter);
                }

                parameter.Code = settingValue.Key;
                parameter.Value = settingValue.Value;
                parameter.Type = settingValue.Type;
            }

            return project;
        }

        private static Project RecalculateVariables(Project openProject, string decryptionKey)
        {
            _logger.Trace("ProjectController.RecalculateVariables()");

            openProject.IsNew = false;
            openProject.IsUnsaved = false;
            openProject.IsValid = true;

            // Decript Connection String
            openProject.Controller.ConnectionString = openProject.Controller.Encrypt
                                                        ? StringEncryptorHelper.Decrypt(openProject.Controller.EncryptedConnectionString, decryptionKey)
                                                        : openProject.Controller.EncryptedConnectionString;

            return openProject;
        }
    }
}
