using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Domain;

namespace CodeGen.App.Controls.Classes
{
    public class DatabaseType
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Code")]
        public string Code { get; set; }

        [XmlAttribute("Library")]
        public string Library { get; set; }

        [XmlAttribute("Default")]
        public bool Default { get; set; }

        [XmlIgnore]
        private EnumDatabaseTypes _type;

        [XmlIgnore]
        public EnumDatabaseTypes Type
        {
            get
            {
                if (_type == null)
                {
                    EnumDatabaseTypes type;
                    _type = Enum.TryParse(Code, out type) ? type : default(EnumDatabaseTypes);
                }
                return _type;
            }
        }

        public DatabaseType()
        {
            Name = string.Empty;
            Code = string.Empty;
            Library = string.Empty;
            Default = false;
        }
    }
}
