using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    public sealed class DatabaseEntity
    {
        public string Qualifier { get; set; }

        public string Owner { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public List<DatabaseEntityField> Fields { get; set; }

        public DatabaseEntity()
        {
            Fields = new List<DatabaseEntityField>();
        }
    }
}
