using System;
using System.Collections.Generic;
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
        public List<ProjectPropertiesPlugin> Plugins { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectProperties"/> class.
        /// </summary>
        public ProjectProperties()
        {
            Plugins = new List<ProjectPropertiesPlugin>();
        }
    }
}
