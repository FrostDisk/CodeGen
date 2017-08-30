using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    /// <summary>
    /// ProjectPluginProperties
    /// </summary>
    [Serializable]
    public class ProjectPropertiesPlugin : ProjectPluginBase
    {
        /// <summary>
        /// Parameters
        /// </summary>
        [XmlArray("Parameters"), XmlArrayItem("Parameter")]
        public List<PluginParameter> Parameters { get; set; }
    }
}
