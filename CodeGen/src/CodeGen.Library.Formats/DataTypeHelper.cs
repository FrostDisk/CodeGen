using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.Formats
{
    public static class DataTypeHelper
    {
        private static readonly Dictionary<string, string> _values = new Dictionary<string, string>
        {
            {"bit", "bool"},
            {"int", "int"},
            {"bigint", "long"},
            {"smallint", "short"},
            {"tinyint", "short"},
            {"real", "float"},
            {"decimal", "decimal"},
            {"double", "double"},
            {"char", "string"},
            {"varchar", "string"},
            {"text", "string"},
            {"enum", "string"},
            {"datetime", "DateTime"},
            {"date", "DateTime"},
            {"time", "TimeSpan"},
            {"blob", "object"},
            {"longblob", "object"}
        };

        public static string GetCSharpType(string sqlDataType)
        {
            string cSharpDataType;
            return _values.TryGetValue(sqlDataType, out cSharpDataType) ? cSharpDataType : "object";
        }
    }
}
