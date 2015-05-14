using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectPlugin
    {
        [XmlAttribute("Assembly")]
        public string Assembly { get; set; }

        [XmlAttribute("Type")]
        public string Type { get; set; }
    }
}
