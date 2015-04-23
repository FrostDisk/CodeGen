using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.AccessModel
{
    public interface ITransaction : IDisposable
    {
        bool IsCommitted { get; set; }

        void Rollback();

        void Commit();
    }
}
