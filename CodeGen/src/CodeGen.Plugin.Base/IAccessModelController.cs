using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IAccessModelController
    /// </summary>
    public interface IAccessModelController : IPluginBase
    {
        /// <summary>
        /// DatabaseTypeCode
        /// </summary>
        string DatabaseTypeCode { get; }

        /// <summary>
        /// IsLoaded
        /// </summary>
        bool IsLoaded { get; }

        /// <summary>
        /// HaveCustomConnectionStringForm
        /// </summary>
        bool HaveCustomConnectionStringForm { get; }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        bool Load(string connectionString);

        /// <summary>
        /// ShowGenerateConnectionStringForm
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        bool ShowGenerateConnectionStringForm(out string connectionString);

        /// <summary>
        /// GetTableList
        /// </summary>
        /// <returns></returns>
        List<string> GetTableList();

        /// <summary>
        /// GetEntityInfo
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        DatabaseEntity GetEntityInfo(string tableName);

        /// <summary>
        /// CheckConnection
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        bool CheckConnection(string connectionString);
    }
}
