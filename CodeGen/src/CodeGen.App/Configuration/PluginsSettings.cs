using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    /// <summary>
    /// PluginsSettings
    /// </summary>
    [Serializable]
    public class PluginsSettings
    {
        /// <summary>
        /// Gets or sets the plugins.
        /// </summary>
        [XmlArray("Assemblies"), XmlArrayItem("Assembly")]
        public List<PluginAssembly> Assemblies { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsSettings"/> class.
        /// </summary>
        public PluginsSettings()
        {
            Assemblies = new List<PluginAssembly>();
        }
    }
}
