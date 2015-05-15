﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public sealed class SqlServerController : IAccessModelController
    {
        private String _connectionString;

        public String Name
        {
            get { return "Sql Server"; }
        }

        public string Description
        {
            get { return "Sql Server Database Controller"; }
        }

        public PluginSettings Settings { get; private set; }

        public String DatabaseTypeCode
        {
            get { return "SqlServer"; }
        }

        public Boolean IsLoaded { get; private set; }

        public Boolean HaveCustomConnectionStringForm { get { return false; } }

        public void UpdateSettings(PluginSettings settings)
        {

        }

        public Boolean Load(String connectionString)
        {
            _connectionString = connectionString;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Close();
            }

            IsLoaded = true;

            return true;
        }

        public Boolean ShowGenerateConnectionStringForm(out String connectionString)
        {
            FormGenerateConnectionString form = new FormGenerateConnectionString();
            form.LoadLocalVariables();

            if (form.ShowDialog() == DialogResult.OK)
            {
                connectionString = form.GetConnectionString();
                return true;
            }

            connectionString = string.Empty;
            return false;
        }

        public List<String> GetTableList()
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller isn't loaded");
            }

            List<string> tables = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataTable dtTables = connection.GetSchema("Tables");
                connection.Close();

                tables.AddRange(from DataRow row in dtTables.Rows select row["TABLE_NAME"].ToString());
            }

            tables.Sort();

            return tables;
        }

        public DatabaseEntity GetEntityInfo(String tableName)
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller isn't loaded");
            }

            DatabaseEntity entity = new DatabaseEntity();

            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_tables";
                command.Parameters.AddWithValue("@table_name", tableName);

                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                if (table.Rows.Count == 0)
                {
                    throw new DataException("Table not found in database");
                }

                DataRow row = table.Rows[0];

                entity.Qualifier = row["TABLE_QUALIFIER"].ToString();
                entity.Owner = row["TABLE_OWNER"].ToString();
                entity.Name = row["TABLE_NAME"].ToString();
                entity.Type = row["TABLE_TYPE"].ToString();
            }

            List<string> typesWithoutPrecision = new List<string> {"int", "tinyint", "bigint", "bit", "datetime", "date", "real", "float", "text"};
            List<string> typesWithDoublePrecision = new List<string> { "decimal" };

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_columns";
                command.Parameters.AddWithValue("@table_name", tableName);

                DataTable table = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                foreach (DataRow row in table.Rows)
                {
                    string typeName = Convert.ToString(row["TYPE_NAME"]);
                    Match match = Regex.Match(typeName, "(identity)");

                    string dataType = match.Success ? typeName.Substring(0, match.Index).Trim() : typeName;

                    string fullDataType;
                    if (typesWithDoublePrecision.Exists(t => t.Equals(dataType)))
                    {
                        fullDataType = string.Format("{0}({1},{2})", dataType, row["PRECISION"], row["SCALE"]);
                    }
                    else
                    {
                        fullDataType = !typesWithoutPrecision.Exists(t => t.Equals(dataType)) ? string.Format("{0}({1})", dataType, row["PRECISION"]) : dataType;
                    }

                    DatabaseEntityField columna = new DatabaseEntityField
                    {
                        ColumnName = Convert.ToString(row["COLUMN_NAME"]),
                        IsPrimaryKey = match.Success,
                        DataType = Convert.ToInt16(row["DATA_TYPE"]),
                        TypeName = fullDataType.Trim(),
                        SimpleTypeName = dataType,
                        Precision = Convert.ToInt32(row["PRECISION"]),
                        Length = Convert.ToInt32(row["LENGTH"]),
                        Scale = row["SCALE"] != DBNull.Value ? Convert.ToInt16(row["SCALE"]) : (Int16?)null,
                        Radix = row["RADIX"] != DBNull.Value ? Convert.ToInt16(row["RADIX"]) : (Int16?)null,
                        IsNullable = Convert.ToBoolean(row["NULLABLE"]),
                        
                    };
                    entity.Fields.Add(columna);
                }
            }

            return entity;
        }
    }
}