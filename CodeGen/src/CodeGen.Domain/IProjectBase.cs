using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Domain
{
    public interface IProjectBase
    {
        string Name { get; set; }

        int Version { get; set; }

        EnumDatabaseTypes Type { get; set; }

        SourceCodeType Source { get; set; }
    }
}
