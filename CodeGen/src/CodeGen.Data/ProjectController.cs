using CodeGen.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        private static Project RecalculateVariables(Project openProject)
        {
            openProject.IsNew = false;
            openProject.IsUnsaved = false;
            openProject.IsValid = true;

            return openProject;
        }
    }
}
