using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Utils;

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
