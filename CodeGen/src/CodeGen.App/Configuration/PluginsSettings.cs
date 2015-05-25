using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    [Serializable]
    public class PluginsSettings
    {
        [XmlArray("Plugins"), XmlArrayItem("Assembly")]
        public List<PluginAssembly> Plugins { get; set; }

        public PluginsSettings()
        {
            Plugins = new List<PluginAssembly>();
        }
    }
}
