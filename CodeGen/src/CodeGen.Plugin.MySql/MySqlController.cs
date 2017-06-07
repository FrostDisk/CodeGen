using CodeGen.Plugin.Base;
using CodeGen.Plugin.MySql.Properties;
using CodeGen.Plugin.MySql.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CodeGen.Plugin.MySql
{
    public sealed class MySqlController : IAccessModelController
    {
        private String _connectionString;

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return "MySql Access-Model Controller"; }
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
            get { return "MySql Access-Model Controller"; }
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

        public PluginSettings Settings { get; private set; }

        public void UpdateSettings(PluginSettings settings)
        {
            
        }

        public string DatabaseTypeCode
        {
            get { return "MySql"; }
        }

        public bool IsLoaded { get; private set; }

        public bool HaveCustomConnectionStringForm
        {
            get { return true; }
        }

        public bool Load(string connectionString)
        {
            _connectionString = connectionString;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                connection.Close();
            }

            IsLoaded = true;

            return true;
        }

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

        public List<string> GetTableList()
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller isn't loaded");
            }

            List<string> tables = new List<string>();

            MySqlConnection connection = new MySqlConnection(_connectionString);
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SHOW TABLES;";
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tables.Add(reader.GetValue(0).ToString());
                }
                connection.Close();
            }

            tables.Sort();

            return tables;
        }

        public DatabaseEntity GetEntityInfo(string tableName)
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller isn't loaded");
            }

            DatabaseEntity entity = new DatabaseEntity();

            MySqlConnection connection = new MySqlConnection(_connectionString);

            connection.Open();

            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "DESCRIBE " + tableName + ";";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string field = Convert.ToString(reader.GetValue(0));
                    string type = Convert.ToString(reader.GetValue(1));
                    string _null = Convert.ToString(reader.GetValue(2));
                    string key = Convert.ToString(reader.GetValue(3));

                    Match match = Regex.Match(type, "[0-9]+");

                    string dataType = Regex.Replace(type, "\\([0-9a-zA-Z,\']+\\)", string.Empty).Replace("unsigned", string.Empty).Trim().ToLower();
                    string fullDataType = type.Replace("unsigned", string.Empty).Trim().ToLower();

                    DatabaseEntityField columna = new DatabaseEntityField
                    {
                        ColumnName = field,
                        IsPrimaryKey = key.Equals("PRI"),
                        DataType = 0,
                        TypeName = fullDataType,
                        SimpleTypeName = dataType,
                        Precision = match.Success ? Convert.ToInt32(match.Value) : -1,
                        Length = 0,
                        Scale = (Int16?)null,
                        Radix = (Int16?)null,
                        IsNullable = _null.Equals("YES"),

                    };
                    entity.Fields.Add(columna);
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
