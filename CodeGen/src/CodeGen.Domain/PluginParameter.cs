using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class PluginParameter
    {
        [XmlAttribute("Code")]
        public string Code { get; set; }

        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("Type")]
        public string TypeName
        {
            get { return Type != null ? Type.ToString() : null; }
            set { Type = Type.GetType(value); }
        }

        [XmlIgnore]
        public Type Type { get; set; }

        [XmlAttribute("UseDefault")]
        public bool UseDefault { get; set; }

        public override string ToString()
        {
            return string.Format("{0}={1}{2}", Code, Value, UseDefault ? " (default)" : string.Empty);
        }
    }
}
