using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Domain;

namespace CodeGen.Core
{
    public class SupportedType
    {
        public string Name { get; set; }

        public string Assembly { get; set; }

        public string Type { get; set; }

        public object Item { get; set; }
    }
}
