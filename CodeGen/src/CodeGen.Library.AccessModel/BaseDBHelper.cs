using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Library.System.Configuration;

namespace CodeGen.Library.AccessModel
{
    public class BaseDBHelper : IDBHelper
    {
        public string ConnectionString { get; private set; }

        public string ConnectionStringKey { get; private set; }

        public BaseDBHelper(string connectionStringKey, bool isFullConnectionString = false)
        {
            ConnectionStringKey = !isFullConnectionString ? connectionStringKey : string.Empty;
            ConnectionString = isFullConnectionString ? connectionStringKey : ConfigHelper.GetConnectionString(connectionStringKey);
        }

        public T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new()
        {
            DataTable table = new DataTable();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return table.Rows.Count > 0 ? buildFunction(table.Rows[0]) : new T();
        }

        public T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new()
        {
            T item = new T();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = buildFunction(reader);
                        }
                    }
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return item;
        }

        public T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetEntity(storedProcedureName,
                                  new ParameterCollection
                                      {
                                          parameter
                                      },
                                  buildFunction);
        }

        public T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetEntity(storedProcedureName,
                                  new ParameterCollection
                                      {
                                          parameter
                                      },
                                  buildFunction);
        }

        public T GetEntity<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetEntity(storedProcedureName, new ParameterCollection(), buildFunction);
        }

        public T GetEntity<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetEntity(storedProcedureName, new ParameterCollection(), buildFunction);
        }

        public T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new()
        {
            DataTable table = new DataTable();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return table.Rows.Count > 0 ? buildFunction(table.Rows[0]) : new T();
        }

        public T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new()
        {
            T item = new T();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = buildFunction(reader);
                        }
                    }
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return item;
        }

        public T GetEntityFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetEntityFromSql(query,
                                         new ParameterCollection
                                             {
                                                 parameter
                                             },
                                         buildFunction);
        }

        public T GetEntityFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetEntityFromSql(query,
                                         new ParameterCollection
                                             {
                                                 parameter
                                             },
                                         buildFunction);
        }

        public T GetEntityFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetEntityFromSql(query, new ParameterCollection(), buildFunction);
        }

        public T GetEntityFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetEntityFromSql(query, new ParameterCollection(), buildFunction);
        }

        public List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new()
        {
            DataTable table = new DataTable();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return (from DataRow row in table.Rows select buildFunction(row)).ToList();
        }

        public List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new()
        {
            List<T> lista = new List<T>();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T item = buildFunction(dr);
                            lista.Add(item);
                        }
                    }
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return lista;
        }

        public List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetCollection(storedProcedureName,
                                    new ParameterCollection
                                        {
                                            parameter
                                        },
                                    buildFunction);
        }

        public List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetCollection(storedProcedureName,
                                    new ParameterCollection
                                        {
                                            parameter
                                        },
                                    buildFunction);
        }

        public List<T> GetCollection<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetCollection(storedProcedureName, new ParameterCollection(), buildFunction);
        }

        public List<T> GetCollection<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetCollection(storedProcedureName, new ParameterCollection(), buildFunction);
        }

        public List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new()
        {
            DataTable table = new DataTable();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return (from DataRow row in table.Rows select buildFunction(row)).ToList();
        }

        public List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new()
        {
            List<T> lista = new List<T>();

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = buildFunction(reader);
                            lista.Add(item);
                        }
                    }
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return lista;
        }

        public List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetCollectionFromSql(query,
                                           new ParameterCollection
                                               {
                                                   parameter
                                               },
                                           buildFunction);
        }

        public List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetCollectionFromSql(query,
                                           new ParameterCollection
                                               {
                                                   parameter
                                               },
                                           buildFunction);
        }

        public List<T> GetCollectionFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new()
        {
            return GetCollectionFromSql(query, new ParameterCollection(), buildFunction);
        }

        public List<T> GetCollectionFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new()
        {
            return GetCollectionFromSql(query, new ParameterCollection(), buildFunction);
        }

        public DataTable GetDataTable(string storedProcedureName, ParameterCollection parametros = null)
        {
            DataTable table = new DataTable("Results");

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parametros, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return table;
        }

        public DataTable GetDataTable(string storedProcedureName, Parameter parameter)
        {
            return GetDataTable(storedProcedureName,
                                    new ParameterCollection
                                        {
                                            parameter
                                        });
        }

        public DataTable GetDataTableFromSql(string query, ParameterCollection parameters = null)
        {
            DataTable table = new DataTable("Results");

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return table;
        }

        public DataTable GetDataTableFromSql(string query, Parameter parameter)
        {
            return GetDataTableFromSql(query,
                                           new ParameterCollection
                                               {
                                                   parameter
                                               });
        }

        public T GetScalar<T>(string storedProcedureName, ParameterCollection parameters = null)
        {
            object result;

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    result = command.ExecuteScalar() ?? default(T);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return (T)Convert.ChangeType(result, typeof(T));
        }

        public T GetScalar<T>(string storedProcedureName, Parameter parameter)
        {
            return GetScalar<T>(storedProcedureName,
                                     new ParameterCollection
                                         {
                                             parameter
                                         });
        }

        public T GetScalarFromSql<T>(string query, ParameterCollection parameters = null)
        {
            object result;

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    result = command.ExecuteScalar() ?? default(T);
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return (T)Convert.ChangeType(result, typeof(T));
        }

        public T GetScalarFromSql<T>(string query, Parameter parameter)
        {
            return GetScalarFromSql<T>(query,
                                            new ParameterCollection
                                                {
                                                    parameter
                                                });
        }

        public int ExecuteStoredProcedure(string storedProcedureName, ParameterCollection parameters = null)
        {
            int result;

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    ConfigureParameters(parameters, command);

                    result = command.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return result;
        }

        public int ExecuteStoredProcedure(string storedProcedureName, Parameter parameter)
        {
            return ExecuteStoredProcedure(storedProcedureName,
                                         new ParameterCollection
                                             {
                                                 parameter
                                             });
        }

        public int ExecuteSql(string query, ParameterCollection parameters = null)
        {
            int result;

            SqlConnection connection = GetActiveConnection();

            try
            {
                AbrirConexion(connection);

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    ConfigureParameters(parameters, command);

                    result = command.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion(connection);
            }

            return result;
        }

        public int ExecuteSql(string query, Parameter parameter)
        {
            return ExecuteSql(query,
                               new ParameterCollection
                                   {
                                       parameter
                                   });
        }

        public Transaction CreateTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            return new Transaction(new SqlConnection(ConnectionString), isolationLevel);
        }

        private SqlConnection GetActiveConnection()
        {
            Transaction context = Transaction.Active;

            return context != null ? context.connection : new SqlConnection(ConnectionString);
        }

        private void ConfigureParameters(IEnumerable<Parameter> parametros, SqlCommand command)
        {
            Transaction context = Transaction.Active;
            if (context != null)
            {
                command.Transaction = context.transaction;
            }

            if (parametros != null)
            {
                foreach (Parameter parametro in parametros)
                {
                    command.Parameters.Add(GetParameter(parametro));
                }
            }
        }

        private SqlParameter GetParameter(Parameter parametro)
        {
            switch (parametro.Type)
            {
                default: { return new SqlParameter(parametro.Name, parametro.Value); }
                case ParameterType.BINARY: { return new SqlParameter(parametro.Name, SqlDbType.Binary) { Value = parametro.Value }; }
                case ParameterType.BOOL: { return new SqlParameter(parametro.Name, SqlDbType.Bit) { Value = parametro.Value }; }
                case ParameterType.FLOAT: { return new SqlParameter(parametro.Name, SqlDbType.Float) { Value = parametro.Value }; }
                case ParameterType.DOUBLE: { return new SqlParameter(parametro.Name, SqlDbType.Real) { Value = parametro.Value }; }
                case ParameterType.DECIMAL: { return new SqlParameter(parametro.Name, SqlDbType.Decimal) { Value = parametro.Value }; }
                case ParameterType.LONG: { return new SqlParameter(parametro.Name, SqlDbType.BigInt) { Value = parametro.Value }; }
                case ParameterType.INT: { return new SqlParameter(parametro.Name, SqlDbType.Int) { Value = parametro.Value }; }
                case ParameterType.SHORT: { return new SqlParameter(parametro.Name, SqlDbType.SmallInt) { Value = parametro.Value }; }
                case ParameterType.VARCHAR: { return new SqlParameter(parametro.Name, SqlDbType.VarChar) { Value = parametro.Value }; }
                case ParameterType.TEXT: { return new SqlParameter(parametro.Name, SqlDbType.Text) { Value = parametro.Value }; }
                case ParameterType.LONG_TEXT: { return new SqlParameter(parametro.Name, SqlDbType.Text) { Value = parametro.Value }; }
                case ParameterType.DATETIME: { return new SqlParameter(parametro.Name, SqlDbType.DateTime) { Value = parametro.Value }; }
                case ParameterType.DATE: { return new SqlParameter(parametro.Name, SqlDbType.Date) { Value = parametro.Value }; }
                case ParameterType.GUID: { return new SqlParameter(parametro.Name, SqlDbType.UniqueIdentifier) { Value = parametro.Value }; }
                case ParameterType.DATATABLE:
                    {
                        return !string.IsNullOrWhiteSpace(parametro.ComplexDataTypeName)
                                   ? new SqlParameter(parametro.Name, SqlDbType.Udt)
                                   {
                                       TypeName = parametro.ComplexDataTypeName,
                                       Value = parametro.Value
                                   }
                                   : new SqlParameter(parametro.Name, parametro.Value);
                    }
            }
        }

        internal void AbrirConexion(SqlConnection connection)
        {
            if (Transaction.Active == null && connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        internal void CerrarConexion(SqlConnection connection)
        {
            if (Transaction.Active == null && connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
