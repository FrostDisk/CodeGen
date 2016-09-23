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
        [XmlArray("Plugins"), XmlArrayItem("Assembly")]
        public List<PluginAssembly> Plugins { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsSettings"/> class.
        /// </summary>
        public PluginsSettings()
        {
            Plugins = new List<PluginAssembly>();
        }
    }
}
