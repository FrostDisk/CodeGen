using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public class DatabaseEntityField
    {
        public String ColumnName { get; set; }

        public Boolean IsPrimaryKey { get; set; }

        public Int16 DataType { get; set; }

        public String TypeName { get; set; }

        public String SimpleTypeName { get; set; }

        public Int32 Precision { get; set; }

        public Int32 Length { get; set; }

        public Int16? Scale { get; set; }

        public Int16? Radix { get; set; }

        public Boolean IsNullable { get; set; }

        public String DefaultValue { get; set; }
    }
}
