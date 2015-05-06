using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectProperties
    {
        [XmlElement("General")]
        public GeneralProjectProperties General { get; set; }

        [XmlElement("Classes")]
        public ClassesProjectProperties Classes { get; set; }

        [XmlElement("Procedures")]
        public ProceduresProjectProperties Procedures { get; set; }

        [XmlElement("DataAccess")]
        public DataAccessProjectProperties DataAccess { get; set; }

        public ProjectProperties()
        {
            General = new GeneralProjectProperties();
            Classes = new ClassesProjectProperties();
            Procedures = new ProceduresProjectProperties();
            DataAccess = new DataAccessProjectProperties();
        }
    }
}
