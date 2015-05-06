using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ClassesProjectProperties
    {
        [XmlElement("DomainPrefix")]
        public string DomainPrefix { get; set; }

        [XmlElement("DomainSuffix")]
        public string DomainSuffix { get; set; }

        [XmlElement("DataAccessPrefix")]
        public string DataAccessPrefix { get; set; }

        [XmlElement("DataAccessSuffix")]
        public string DataAccessSuffix { get; set; }

        [XmlElement("EntityPrefix")]
        public string EntityPrefix { get; set; }

        [XmlElement("EntitySuffix")]
        public string EntitySuffix { get; set; }

        [XmlElement("EnumPrefix")]
        public string EnumPrefix { get; set; }

        [XmlElement("EnumSuffix")]
        public string EnumSuffix { get; set; }

        public ClassesProjectProperties()
        {
            DomainPrefix = string.Empty;
            DomainSuffix = string.Empty;
            DataAccessPrefix = string.Empty;
            DataAccessSuffix = string.Empty;
            EntityPrefix = string.Empty;
            EntitySuffix = string.Empty;
            EnumPrefix = string.Empty;
            EnumSuffix = string.Empty;
        }
    }
}
