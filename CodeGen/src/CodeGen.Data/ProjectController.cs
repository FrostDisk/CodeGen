using CodeGen.Domain;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;
using CodeGen.Library.Security;
using CodeGen.Library.Formats;

namespace CodeGen.Data
{
    /// <summary>
    /// ProjectController
    /// </summary>
    public static class ProjectController
    {
        /// <summary>
        /// Creates the empty project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="projectDirectory">The project directory.</param>
        /// <returns></returns>
        public static Project CreateEmptyProject(string projectName, string projectDirectory)
        {
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
            // Encrypt Connection String
            project.EncryptedConnectionString = StringEncryptorHelper.Encrypt(project.ConnectionString, encryptionKey);

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
        /// <param name="assemblyFile">The assembly file.</param>
        /// <param name="plugin">The plugin.</param>
        /// <returns></returns>
        public static ProjectPluginProperties GetPluginProperties(Project project, string assemblyFile, string plugin)
        {
            if (project.Properties == null
                || project.Properties.Plugins == null)
            {
                return null;
            }

            return project.Properties.Plugins.FirstOrDefault(p => p.Assembly == assemblyFile && p.Type == plugin);
        }

        /// <summary>
        /// Updates the plugin settings.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="plugin">The plugin.</param>
        /// <returns></returns>
        public static Project UpdatePluginSettings(Project project, IGeneratorTemplate plugin)
        {
            if (project.Properties == null)
            {
                project.Properties = new ProjectProperties();
            }

            if (project.Properties.Plugins == null)
            {
                project.Properties.Plugins = new List<ProjectPluginProperties>();
            }

            var type = plugin.GetType();
            var assemblyFile = Path.GetFileName(type.Assembly.Location);

            var pluginAssembly = project.Properties.Plugins.FirstOrDefault(p => p.Assembly == assemblyFile && p.Type == type.FullName);
            if (pluginAssembly == null)
            {
                pluginAssembly = new ProjectPluginProperties();
                pluginAssembly.Assembly = assemblyFile;
                pluginAssembly.Type = type.FullName;
                project.Properties.Plugins.Add(pluginAssembly);
            }

            if (pluginAssembly.Parameters == null)
            {
                pluginAssembly.Parameters = new List<PluginParameter>();
            }

            pluginAssembly.Parameters.Clear();
            foreach (PluginSettingValue settingValue in plugin.Settings)
            {
                PluginParameter parameter = new PluginParameter();
                parameter.Code = settingValue.Key;
                parameter.Value = settingValue.Value;
                parameter.UseDefault = settingValue.UseDefault;
                parameter.Type = settingValue.Type;
                pluginAssembly.Parameters.Add(parameter);
            }

            return project;
        }

        private static Project RecalculateVariables(Project openProject, string decryptionKey)
        {
            openProject.IsNew = false;
            openProject.IsUnsaved = false;
            openProject.IsValid = true;

            // Decript Connection String
            openProject.ConnectionString = StringEncryptorHelper.Decrypt(openProject.EncryptedConnectionString, decryptionKey);

            return openProject;
        }
    }
}
