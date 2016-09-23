using System;
using System.Data;
using System.Data.SqlClient;

namespace CodeGen.Library.AccessModel
{
    /// <summary>
    /// Transaction
    /// </summary>
    public class Transaction : ITransaction
    {
        internal BaseDBHelper instance;

        internal SqlConnection connection;

        internal SqlTransaction transaction;

        internal Transaction(SqlConnection sqlConnection, IsolationLevel isolationLevel, BaseDBHelper dbHelper)
        {
            connection = sqlConnection;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            transaction = connection.BeginTransaction(isolationLevel);
            instance = dbHelper;

            _previous = _active;
            _active = this;
            IsCommitted = false;
        }

        [ThreadStatic]
        private static Transaction _active;

        private readonly Transaction _previous;

        /// <summary>
        /// Active
        /// </summary>
        public static Transaction Active
        {
            get
            {
                return _active;
            }
        }

        /// <summary>
        /// IsCommitted
        /// </summary>
        public bool IsCommitted { get; set; }

        /// <summary>
        /// Rollback
        /// </summary>
        public void Rollback()
        {
            transaction.Rollback();

            Close();
        }

        /// <summary>
        /// Commit
        /// </summary>
        public void Commit()
        {
            transaction.Commit();

            Close();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            if (!IsCommitted)
            {
                Rollback();
            }
            _active = _previous;
        }

        private void Close()
        {
            transaction = null;
            IsCommitted = true;

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection = null;
        }
    }
}
