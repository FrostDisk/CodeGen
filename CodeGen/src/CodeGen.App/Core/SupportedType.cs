using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeGen.Domain;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public class SupportedType
    {
        public string Name { get; set; }

        public string Assembly { get; set; }

        public string Type { get; set; }

        public IPluginBase Item { get; set; }
    }
}
