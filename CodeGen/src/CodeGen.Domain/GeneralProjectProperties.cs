using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class GeneralProjectProperties
    {
        [XmlElement("BaseNamespace")]
        public string BaseNamespace { get; set; }

        [XmlElement("DomainNamespace")]
        public string DomainNamespace { get; set; }

        [XmlElement("DataAccessNamespace")]
        public string DataAccessNamespace { get; set; }

        [XmlElement("EntityNamespace")]
        public string EntityNamespace { get; set; }

        [XmlElement("EnumNamespace")]
        public string EnumNamespace { get; set; }

        public GeneralProjectProperties()
        {
            BaseNamespace = string.Empty;
            DomainNamespace = string.Empty;
            DataAccessNamespace = string.Empty;
            EntityNamespace = string.Empty;
            EnumNamespace = string.Empty;
        }
    }
}
