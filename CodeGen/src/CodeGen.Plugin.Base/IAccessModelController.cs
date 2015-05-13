using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IAccessModelController
    {
        Boolean IsLoaded { get; }

        Boolean Load(String connectionString);

        List<String> GetTableList();

        DatabaseEntity GetEntityInfo(String tableName);
    }
}
