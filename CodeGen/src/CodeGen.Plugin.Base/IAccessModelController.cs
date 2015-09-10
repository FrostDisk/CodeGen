using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    public interface IAccessModelController : IPluginBase
    {
        string DatabaseTypeCode { get; }

        bool IsLoaded { get; }

        bool HaveCustomConnectionStringForm { get; }

        bool Load(string connectionString);

        bool ShowGenerateConnectionStringForm(out string connectionString);

        List<string> GetTableList();

        DatabaseEntity GetEntityInfo(string tableName);

        bool CheckConnection(string connectionString);
    }
}
