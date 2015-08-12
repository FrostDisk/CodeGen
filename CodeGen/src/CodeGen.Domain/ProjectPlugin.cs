using System;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectPlugin
    {
        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        [XmlAttribute("Type")]
        public string Type { get; set; }
    }
}
