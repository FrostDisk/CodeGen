using System;
using System.Collections.Generic;
using CodeGen.Plugin.Base;

namespace CodeGen.Plugin.MySql
{
    public sealed class MySqlController : IAccessModelController
    {
        private String _connectionString;

        #region plugin base 

        public string Name
        {
            get { return "MySql"; }
        }

        public string Description
        {
            get { return "MySql Database Controller"; }
        }

        public PluginSettings Settings { get; private set; }

        public void UpdateSettings(PluginSettings settings)
        {
            
        }

        #endregion

        public string DatabaseTypeCode
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsLoaded
        {
            get { throw new NotImplementedException(); }
        }

        public bool HaveCustomConnectionStringForm
        {
            get { throw new NotImplementedException(); }
        }

        public bool Load(string connectionString)
        {
            throw new NotImplementedException();
        }

        public bool ShowGenerateConnectionStringForm(out string connectionString)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTableList()
        {
            throw new NotImplementedException();
        }

        public DatabaseEntity GetEntityInfo(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
