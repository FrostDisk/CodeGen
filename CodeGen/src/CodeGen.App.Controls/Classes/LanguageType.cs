using CodeGen.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.App.Controls.Classes
{
    [Serializable]
    public class LanguageType
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
        private EnumLanguages _type;

        [XmlIgnore]
        public EnumLanguages Type
        {
            get
            {
                if (_type == null)
                {
                    EnumLanguages type;
                    _type = Enum.TryParse(Code, out type) ? type : default(EnumLanguages);
                }
                return _type;
            }
        }

        public LanguageType()
        {
            Name = string.Empty;
            Code = string.Empty;
            Library = string.Empty;
            Default = false;
        }
    }
}
