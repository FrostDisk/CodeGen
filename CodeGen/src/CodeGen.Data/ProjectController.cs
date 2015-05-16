using CodeGen.Domain;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;

namespace CodeGen.Data
{
    public static class ProjectController
    {
        public static Project CreateEmptyProject(string projectName, string projectDirectory)
        {
            Project project = new Project();
            project.Name = projectName;
            project.Version = Project.ActiveVersion;
            project.SaveLocation = Path.Combine(projectDirectory, string.Format("{0}.cgproj", projectName.ToLower()));
            project.SaveDirectory = projectDirectory;
            project.IsNew = true;
            project.IsUnsaved = true;
            project.IsValid = true;

            return project;
        }


        public static void SaveProjectToStream(Project project, Stream projectStream)
        {
            using (StreamWriter streamWriter = new StreamWriter(projectStream, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Project));

                serializer.Serialize(streamWriter, project);
            }

            project.IsNew = false;
            project.IsUnsaved = false;
        }

        public static Project OpenProjectFromLocation(string projectLocation)
        {
            using (StreamReader streamReader = new StreamReader(projectLocation, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Project));

                Project project = (Project)serializer.Deserialize(streamReader);

                if (project != null)
                {
                    project.SaveLocation = projectLocation;
                    project.SaveDirectory = Path.GetDirectoryName(projectLocation);
                    return RecalculateVariables(project);
                }
            }

            return new Project();
        }

        public static ProjectPluginProperties GetPluginProperties(Project project, string assemblyFile, string plugin)
        {
            if (project.Properties == null
                || project.Properties.Plugins == null)
            {
                return null;
            }

            return project.Properties.Plugins.FirstOrDefault(p => p.Assembly == assemblyFile && p.Type == plugin);
        }

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

        private static Project RecalculateVariables(Project openProject)
        {
            openProject.IsNew = false;
            openProject.IsUnsaved = false;
            openProject.IsValid = true;

            return openProject;
        }
    }
}
