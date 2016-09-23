using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectProperties
    /// </summary>
    [Serializable]
    public class ProjectProperties
    {
        /// <summary>
        /// Plugins
        /// </summary>
        [XmlArray("Plugins"), XmlArrayItem("Plugin")]
        public List<ProjectPluginProperties> Plugins { get; set; }

        /// <summary>
        /// ProjectProperties
        /// </summary>
        public ProjectProperties()
        {
            Plugins = new List<ProjectPluginProperties>();
        }
    }
}
