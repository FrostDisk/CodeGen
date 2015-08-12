using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectPluginProperties : ProjectPlugin
    {
        [XmlArray("Parameters"), XmlArrayItem("Parameter")]
        public List<PluginParameter> Parameters { get; set; }
    }
}
