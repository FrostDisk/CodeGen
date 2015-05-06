using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    public class ProceduresProjectProperties
    {
        [XmlElement("StoredProcedurePrefix")]
        public string StoredProcedurePrefix { get; set; }

        [XmlElement("StoredProcedureSaveSuffix")]
        public string StoredProcedureSaveSuffix { get; set; }

        [XmlElement("StoredProcedureGetByIdSuffix")]
        public string StoredProcedureGetByIdSuffix { get; set; }

        [XmlElement("StoredProcedureDeleteById")]
        public string StoredProcedureDeleteById { get; set; }

        [XmlElement("StoredProcedureListSuffix")]
        public string StoredProcedureListSuffix { get; set; }

        public ProceduresProjectProperties()
        {
            StoredProcedurePrefix = string.Empty;
            StoredProcedureSaveSuffix = string.Empty;
            StoredProcedureGetByIdSuffix = string.Empty;
            StoredProcedureDeleteById = string.Empty;
            StoredProcedureListSuffix = string.Empty;
        }
    }
}
