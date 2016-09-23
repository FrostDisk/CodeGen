using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.AccessModel
{
    /// <summary>
    /// ITransaction
    /// </summary>
    public interface ITransaction : IDisposable
    {
        /// <summary>
        /// IsCommitted
        /// </summary>
        bool IsCommitted { get; set; }

        /// <summary>
        /// Rollback
        /// </summary>
        void Rollback();

        /// <summary>
        /// Commit
        /// </summary>
        void Commit();
    }
}
