using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IAccessModelController : IPluginBase
    {
        String DatabaseTypeCode { get; }

        Boolean IsLoaded { get; }

        Boolean HaveCustomConnectionStringForm { get; }

        Boolean Load(String connectionString);

        String ShowGenerateConnectionStringForm();

        List<String> GetTableList();

        DatabaseEntity GetEntityInfo(String tableName);
    }
}
