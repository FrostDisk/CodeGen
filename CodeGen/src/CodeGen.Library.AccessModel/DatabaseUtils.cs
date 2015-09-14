using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CodeGen.Library.AccessModel
{
    public static class DatabaseUtils
    {
        public static bool CheckConnectionString(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = connectionString;

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                connection.Close();
            }

            return true;
        }

        public static string CreateBasicConnectionString(string dataSource, string userId, string password, bool integratedSecurity, string initialCatalog)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = dataSource;
            if (integratedSecurity)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.UserID = userId;
                builder.Password = password;
            }
            builder.InitialCatalog = initialCatalog;

            return builder.ConnectionString;
        }

        public static List<string> GetDatabaseList(string dataSource, string userId, string password, bool integratedSecurity)
        {
            List<string> databaseList = new List<string>();

            SqlConnectionStringBuilder builder = integratedSecurity
                ? new SqlConnectionStringBuilder
                {
                    DataSource = dataSource,
                    IntegratedSecurity = true
                }
                : new SqlConnectionStringBuilder
                {
                    DataSource = dataSource,
                    UserID = userId,
                    Password = password
                };

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                DataTable tblDatabases = connection.GetSchema("Databases");
                connection.Close();

                databaseList.AddRange(from DataRow row in tblDatabases.Rows select row["DATABASE_NAME"].ToString());
            }

            databaseList.Sort();

            return databaseList;
        }
    }
}
