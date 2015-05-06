using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class DataAccessProjectProperties
    {
        [XmlElement("GetEntityByIdMethodName")]
        public string GetEntityByIdMethodName { get; set; }

        [XmlElement("GetScalarMethodName")]
        public string GetScalarMethodName { get; set; }

        [XmlElement("GetCollectionMethodName")]
        public string GetCollectionMethodName { get; set; }

        [XmlElement("GetDataTableMethodName")]
        public string GetDataTableMethodName { get; set; }

        [XmlElement("ExecuteStoredProcedureMethodName")]
        public string ExecuteStoredProcedureMethodName { get; set; }

        [XmlElement("BuildEntityMethodName")]
        public string BuildEntityMethodName { get; set; }

        [XmlElement("AccessModelLibraryNamespace")]
        public string AccessModelLibraryNamespace { get; set; }

        [XmlElement("AccessModelInstanceNamespace")]
        public string AccessModelInstanceNamespace { get; set; }

        [XmlElement("AccessModelInstanceObjectName")]
        public string AccessModelInstanceObjectName { get; set; }

        public DataAccessProjectProperties()
        {
            GetEntityByIdMethodName = string.Empty;
            GetScalarMethodName = string.Empty;
            GetCollectionMethodName = string.Empty;
            GetDataTableMethodName = string.Empty;
            ExecuteStoredProcedureMethodName = string.Empty;
            BuildEntityMethodName = string.Empty;
            AccessModelLibraryNamespace = string.Empty;
            AccessModelInstanceNamespace = string.Empty;
            AccessModelInstanceObjectName = string.Empty;
        }
    }
}
