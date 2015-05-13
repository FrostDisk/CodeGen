using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public sealed class DatabaseEntity
    {
        public String Qualifier { get; set; }

        public String Owner { get; set; }

        public String Name { get; set; }

        public String Type { get; set; }

        public List<DatabaseEntityField> Fields { get; set; }

        public DatabaseEntity()
        {
            Fields = new List<DatabaseEntityField>();
        }
    }
}
