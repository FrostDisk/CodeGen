using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public class GeneratorComponent
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public GeneratorComponent(Int32 id, String name)
        {
            Id = id;
            Name = name;
        }
    }
}
