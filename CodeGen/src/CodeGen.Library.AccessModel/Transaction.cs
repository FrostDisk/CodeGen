using System;
using System.Data;
using System.Data.SqlClient;

namespace CodeGen.Library.AccessModel
{
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

        public static Transaction Active
        {
            get
            {
                return _active;
            }
        }

        public bool IsCommitted { get; set; }

        public void Rollback()
        {
            transaction.Rollback();

            Close();
        }

        public void Commit()
        {
            transaction.Commit();

            Close();
        }

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
