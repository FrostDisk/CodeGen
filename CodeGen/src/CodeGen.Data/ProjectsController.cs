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
using System.Drawing;
using CodeGen.Properties;

namespace CodeGen.Data
{
    /// <summary>
    /// ProjectController
    /// </summary>
    public static class ProjectsController
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
        public static ProjectPropertiesPlugin GetPluginProperties(Project project, string guid)
        {
            _logger.Trace("ProjectController.GetPluginProperties()");

            if (project.Properties == null)
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

            var type = plugin.GetType();
            string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

            var pluginAssembly = project.Properties.Plugins.FirstOrDefault(p => p.Guid.Equals(guid, StringComparison.InvariantCultureIgnoreCase));
            if (pluginAssembly == null)
            {
                pluginAssembly = new ProjectPropertiesPlugin();
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

        /// <summary>
        /// Saves the code to disk.
        /// </summary>
        /// <param name="plugin">The plugin.</param>
        /// <param name="component">The component.</param>
        /// <param name="project">The project.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="code">The code.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public static bool SaveCodeToProject(IGeneratorTemplate plugin, GeneratorComponent component, Project project, string tableName, string code, string fileName)
        {
            _logger.Trace("ProjectController.SaveCodeToDisk()");

            var targetDirectory = Path.Combine(project.SaveDirectory, "Files", tableName);
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            var entity = project.Entities.FirstOrDefault(e => e.Name.Equals(tableName, StringComparison.InvariantCultureIgnoreCase));
            if (entity == null)
            {
                entity = new ProjectEntity();
                entity.Name = tableName;
                project.Entities.Add(entity);
            }

            project.Entities = project.Entities.OrderBy(e => e.Name).ToList();

            string guid = ((GuidAttribute)(plugin.GetType().Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

            var file = entity.Files.FirstOrDefault(f => f.Guid.Equals(guid, StringComparison.InvariantCultureIgnoreCase) && f.Plugin.Equals(plugin.GetType().ToString(), StringComparison.InvariantCultureIgnoreCase) && f.Component.Equals(component.Id));
            if (file == null)
            {
                file = new ProjectEntityFile();
                file.Guid = guid;
                file.Plugin = plugin.GetType().ToString();
                file.Component = component.Id;
                file.File = fileName;
                entity.Files.Add(file);
            }

            entity.Files = entity.Files.OrderBy(e => e.File).ToList();

            var targetLocation = Path.Combine(targetDirectory, fileName);

            File.WriteAllText(targetLocation, code, Encoding.UTF8);

            return true;
        }

        /// <summary>
        /// Gets the image from file.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public static Image GetImageFromFile(Project project, ProjectEntity entity, ProjectEntityFile file)
        {
            _logger.Trace("ProjectController.GetImageFromFile()");

            var targetLocation = Path.Combine(project.SaveDirectory, "Files", entity.Name, file.File);

            if (File.Exists(targetLocation))
            {
                var icon = Icon.ExtractAssociatedIcon(targetLocation);

                return icon.ToBitmap();
            }

            return Resources.page_white_code;
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
