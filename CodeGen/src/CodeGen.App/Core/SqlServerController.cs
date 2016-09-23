using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using CodeGen.Properties;
using CodeGen.Domain;
using CodeGen.Library.AccessModel;

namespace CodeGen.Core
{
    /// <summary>
    /// SqlServerController
    /// </summary>
    /// <seealso cref="CodeGen.Plugin.Base.IAccessModelController" />
    public sealed class SqlServerController : IAccessModelController
    {
        private string _connectionString;

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return "Sql Server Access-Model Controller"; }
        }

        /// <summary>
        /// CreatedBy
        /// </summary>
        public string CreatedBy
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        /// <summary>
        /// Icon
        /// </summary>
        public Image Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return "Sql Server Access-Model Controller"; }
        }

        /// <summary>
        /// Version
        /// </summary>
        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        /// <summary>
        /// Release Notes Url
        /// </summary>
        public string ReleaseNotesUrl
        {
            get { return Resources.DefaultReleaseNotesUrl; }
        }

        /// <summary>
        /// Author Website Url
        /// </summary>
        public string AuthorWebsiteUrl
        {
            get { return Resources.DefaultAuthorWebsiteUrl; }
        }

        /// <summary>
        /// Instance settings object
        /// </summary>
        public PluginSettings Settings { get; private set; }

        /// <summary>
        /// DatabaseTypeCode
        /// </summary>
        public string DatabaseTypeCode
        {
            get { return EnumDatabaseTypes.SqlServer.ToString("G"); }
        }

        /// <summary>
        /// IsLoaded
        /// </summary>
        public bool IsLoaded { get; private set; }

        /// <summary>
        /// Have Custom ConnectionString Form
        /// </summary>
        public bool HaveCustomConnectionStringForm { get { return true; } }

        /// <summary>
        /// Updates the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void UpdateSettings(PluginSettings settings)
        {

        }

        /// <summary>
        /// Loads the specified connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public bool Load(string connectionString)
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

        /// <summary>
        /// Shows the generate connection string form.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public bool ShowGenerateConnectionStringForm(out string connectionString)
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

        /// <summary>
        /// Gets the table list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ApplicationException">The Controller isn't loaded</exception>
        public List<string> GetTableList()
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

        /// <summary>
        /// Gets the entity information.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">The Controller isn't loaded</exception>
        /// <exception cref="DataException">Table not found in database</exception>
        public DatabaseEntity GetEntityInfo(string tableName)
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
            List<string> typesWithDoublePrecision = new List<string> {"decimal", "money"};

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

                    DatabaseEntityField entityField = new DatabaseEntityField
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
                    entity.Fields.Add(entityField);
                }
            }

            return entity;
        }

        /// <summary>
        /// Checks the connection.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public bool CheckConnection(string connectionString)
        {
            try
            {
                return DatabaseUtils.CheckConnectionString(connectionString);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }

            return false;
        }
    }
}
