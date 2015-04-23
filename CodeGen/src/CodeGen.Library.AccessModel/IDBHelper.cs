using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.AccessModel
{
    /// <summary>
    /// DBHelper base interface
    /// </summary>
    public interface IDBHelper
    {
        string ConnectionString { get; }

        string ConnectionStringKey { get; }

        T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        T GetEntity<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new();

        T GetEntity<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new();

        T GetEntityFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollection<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new();

        List<T> GetCollectionFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new();

        DataTable GetDataTable(string storedProcedureName, ParameterCollection parametros = null);

        DataTable GetDataTable(string storedProcedureName, Parameter parameter);

        DataTable GetDataTableFromSql(string query, ParameterCollection parameters = null);

        DataTable GetDataTableFromSql(string query, Parameter parameter);

        T GetScalar<T>(string storedProcedureName, ParameterCollection parameters = null);

        T GetScalar<T>(string storedProcedureName, Parameter parameter);

        T GetScalarFromSql<T>(string query, ParameterCollection parameters = null);

        T GetScalarFromSql<T>(string query, Parameter parameter);

        int ExecuteStoredProcedure(string storedProcedureName, ParameterCollection parameters = null);

        int ExecuteStoredProcedure(string storedProcedureName, Parameter parameter);

        int ExecuteSql(string query, ParameterCollection parameters = null);

        int ExecuteSql(string query, Parameter parameter);
    }
}
