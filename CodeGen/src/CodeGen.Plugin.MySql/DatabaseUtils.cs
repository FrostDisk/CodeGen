using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CodeGen.Plugin.MySql
{
    internal static class DatabaseUtils
    {
        public static bool CheckConnectionString(string connectionString)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = connectionString;

            return true;
        }

        public static string CreateBasicConnectionString(string server, string userId, string password, string database)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = server;
            builder.UserID = userId;
            builder.Password = password;
            builder.Database = database;

            return builder.ConnectionString;
        }

        public static List<string> GetDatabaseList(string server, string userId, string password)
        {
            List<string> databaseList = new List<string>();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = server;
            builder.UserID = userId;
            builder.Password = password;

            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SHOW DATABASES;";
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        databaseList.Add(reader.GetValue(0).ToString());
                    }
                    connection.Close();
                }
            }

            databaseList.Sort();

            return databaseList;
        }
    }
}
