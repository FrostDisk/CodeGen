namespace CodeGen.Plugin.Base
{
    public sealed class DatabaseEntityField
    {
        public string ColumnName { get; set; }

        public bool IsPrimaryKey { get; set; }

        public short DataType { get; set; }

        public string TypeName { get; set; }

        public string SimpleTypeName { get; set; }

        public int Precision { get; set; }

        public int Length { get; set; }

        public short? Scale { get; set; }

        public short? Radix { get; set; }

        public bool IsNullable { get; set; }

        public string DefaultValue { get; set; }
    }
}
