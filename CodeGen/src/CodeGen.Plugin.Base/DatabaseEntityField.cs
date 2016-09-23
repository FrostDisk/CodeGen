namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// DatabaseEntityField
    /// </summary>
    public sealed class DatabaseEntityField
    {
        /// <summary>
        /// ColumnName
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// IsPrimaryKey
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// DataType
        /// </summary>
        public short DataType { get; set; }

        /// <summary>
        /// TypeName
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// SimpleTypeName
        /// </summary>
        public string SimpleTypeName { get; set; }

        /// <summary>
        /// Precision
        /// </summary>
        public int Precision { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Scale
        /// </summary>
        public short? Scale { get; set; }

        /// <summary>
        /// Radix
        /// </summary>
        public short? Radix { get; set; }

        /// <summary>
        /// IsNullable
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// DefaultValue
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
