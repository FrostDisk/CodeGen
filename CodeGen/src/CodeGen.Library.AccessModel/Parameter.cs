using System;
using System.Data;

namespace CodeGen.Library.AccessModel
{
    /// <summary>
    /// Parameter
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Parameter Type
        /// </summary>
        public ParameterType Type { get; private set; }

        /// <summary>
        /// Parameter Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Parameter Value
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Parameter Value is NullAble
        /// </summary>
        public bool IsNullAble { get; private set; }

        /// <summary>
        /// Complex data type name
        /// </summary>
        public string ComplexDataTypeName { get; private set; }

        public Parameter(string name, object value, ParameterType type = ParameterType.DEFAULT)
        {
            Name = name;
            Value = value;
            Type = type;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, bool value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.BOOL;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, float value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.FLOAT;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, double value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.DOUBLE;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, double? value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.DOUBLE;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, decimal value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.DECIMAL;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, decimal? value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.DECIMAL;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, long value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.LONG;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, long? value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.LONG;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, int value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.INT;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, int? value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.INT;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, short? value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.SHORT;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, short value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.SHORT;
            IsNullAble = false;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, string value, bool isText = false, bool isLongText = false)
        {
            Name = name;
            Value = value;
            Type = isText ? isLongText ? ParameterType.LONG_TEXT : ParameterType.TEXT : ParameterType.VARCHAR;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, DateTime value, bool isSimpleDate = false)
        {
            Name = name;
            Value = value;
            Type = isSimpleDate ? ParameterType.DATE : ParameterType.DATETIME;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, Guid value)
        {
            Name = name;
            Value = value;
            Type = ParameterType.GUID;
            IsNullAble = true;
            ComplexDataTypeName = string.Empty;
        }

        public Parameter(string name, DataTable value, string dataTypeName)
        {
            Name = name;
            Value = value;
            Type = ParameterType.DATATABLE;
            IsNullAble = true;
            ComplexDataTypeName = dataTypeName;
        }
    }
}
