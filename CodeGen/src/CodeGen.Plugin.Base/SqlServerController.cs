using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public sealed class SqlServerController : IAccessModelController
    {
        private string _connectionString;


        public bool IsLoaded { get; private set; }

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

        public List<string> GetTableList()
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller is not loaded");
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

        public DatabaseEntity GetEntityInfo(string tableName)
        {
            if (!IsLoaded)
            {
                throw new ApplicationException("The Controller is not loaded");
            }

            return new DatabaseEntity();
        }
    }
}
