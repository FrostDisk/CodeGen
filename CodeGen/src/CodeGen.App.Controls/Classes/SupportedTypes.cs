using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.App.Controls.Classes
{
    [Serializable]
    [XmlRoot("Types")]
    public class SupportedTypes
    {
        [XmlArray("DatabaseTypes"), XmlArrayItem("Type")]
        public List<DatabaseType> DatabaseTypes { get; set; }

        [XmlArray("Languages"), XmlArrayItem("Language")]
        public List<LanguageType> Languages { get; set; }

        public SupportedTypes()
        {
            DatabaseTypes = new List<DatabaseType>();
            Languages = new List<LanguageType>();
        }
    }
}
