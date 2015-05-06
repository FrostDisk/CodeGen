using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.AccessModel
{
    public static class DatabaseUtils
    {
        public static bool CheckConnectionString(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = connectionString;

            return true;
        }

        public static string CreateBasicConnectionString(string dataSource, string userId, string password, string initialCatalog)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = dataSource;
            builder.UserID = userId;
            builder.Password = password;
            builder.InitialCatalog = initialCatalog;

            return builder.ConnectionString;
        }
    }
}
