﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<string> GetDatabaseList(string dataSource, string userId, string password)
        {
            List<string> basesDatos = new List<string>();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
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

                basesDatos.AddRange(from DataRow row in tblDatabases.Rows select row["DATABASE_NAME"].ToString());
            }

            basesDatos.Sort();

            return basesDatos;
        }
    }
}
