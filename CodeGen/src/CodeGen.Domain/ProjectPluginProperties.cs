using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectPluginProperties
    /// </summary>
    [Serializable]
    public class ProjectPluginProperties : ProjectPlugin
    {
        /// <summary>
        /// Parameters
        /// </summary>
        [XmlArray("Parameters"), XmlArrayItem("Parameter")]
        public List<PluginParameter> Parameters { get; set; }
    }
}
