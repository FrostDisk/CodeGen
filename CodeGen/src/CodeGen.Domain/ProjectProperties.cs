using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectProperties
    {
        [XmlArray("Plugins"), XmlArrayItem("Plugin")]
        public List<ProjectPluginProperties> Plugins { get; set; }

        public ProjectProperties()
        {
            Plugins = new List<ProjectPluginProperties>();
        }
    }
}
