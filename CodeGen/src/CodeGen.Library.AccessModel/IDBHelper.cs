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
        /// <summary>
        /// ConnectionString
        /// </summary>
        string ConnectionString { get; }

        /// <summary>
        /// ConnectionStringKey
        /// </summary>
        string ConnectionStringKey { get; }

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntity<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetEntityFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        T GetEntityFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollection<T>(string storedProcedureName, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, ParameterCollection parameters, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, Parameter parameter, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, Func<DataRow, T> buildFunction) where T : new();

        /// <summary>
        /// GetCollectionFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="buildFunction"></param>
        /// <returns></returns>
        List<T> GetCollectionFromSql<T>(string query, Func<IDataReader, T> buildFunction) where T : new();

        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="storedProcedureName"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        DataTable GetDataTable(string storedProcedureName, ParameterCollection parametros = null);

        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        DataTable GetDataTable(string storedProcedureName, Parameter parameter);

        /// <summary>
        /// GetDataTableFromSql
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        DataTable GetDataTableFromSql(string query, ParameterCollection parameters = null);

        /// <summary>
        /// GetDataTableFromSql
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        DataTable GetDataTableFromSql(string query, Parameter parameter);

        /// <summary>
        /// GetScalar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        T GetScalar<T>(string storedProcedureName, ParameterCollection parameters = null);

        /// <summary>
        /// GetScalar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        T GetScalar<T>(string storedProcedureName, Parameter parameter);

        /// <summary>
        /// GetScalarFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        T GetScalarFromSql<T>(string query, ParameterCollection parameters = null);

        /// <summary>
        /// GetScalarFromSql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        T GetScalarFromSql<T>(string query, Parameter parameter);

        /// <summary>
        /// ExecuteStoredProcedure
        /// </summary>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        int ExecuteStoredProcedure(string storedProcedureName, ParameterCollection parameters = null);

        /// <summary>
        /// ExecuteStoredProcedure
        /// </summary>
        /// <param name="storedProcedureName"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        int ExecuteStoredProcedure(string storedProcedureName, Parameter parameter);

        /// <summary>
        /// ExecuteSql
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        int ExecuteSql(string query, ParameterCollection parameters = null);

        /// <summary>
        /// ExecuteSql
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        int ExecuteSql(string query, Parameter parameter);
    }
}
