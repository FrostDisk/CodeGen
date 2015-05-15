using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Windows.Forms;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public sealed class CSharpBaseTemplate : IGeneratorTemplate
    {
        #region properties

        public String Name
        {
            get { return "C# Base Code Template"; }
        }

        public string Description
        {
            get { return "C# Domain/DataAccess Code Template"; }
        }

        public PluginSettings Settings { get; private set; }

        public string LanguageCode
        {
            get { return "CSharp"; }
        }

        public String FileExtension
        {
            get { return ".cs"; }
        }

        public Boolean HaveOptions
        {
            get { return true; }
        }

        public bool HaveCodeComponents
        {
            get { return true; }
        }

        public bool HaveQueryComponents
        {
            get { return true; }
        }

        private FormCSharpCodeConfiguration _formConfiguration;

        #endregion

        #region initialization

        public CSharpBaseTemplate()
        {
            _formConfiguration = new FormCSharpCodeConfiguration();

            Settings = _formConfiguration.GetSettings();
        }

        #endregion

        #region methods

        public void UpdateSettings(PluginSettings settings)
        {
            foreach (PluginSettingValue settingValue in settings)
            {
                _formConfiguration.UpdateSetting(settingValue.Key, settingValue.Value);
            }
        }

        public bool ShowOptionsForm()
        {
            var result = _formConfiguration.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings = _formConfiguration.GetSettings();
                return true;
            }
            return false;
        }

        public List<GeneratorComponent> GetCodeComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eCSharpComponent.DOMAIN, "Domain"),
                new GeneratorComponent((int) eCSharpComponent.DATA_ACCESS, "Data Access"),
            };
        }

        public List<GeneratorComponent> GetQueryComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eCSharpComponent.SAVE, "Save"),
                new GeneratorComponent((int) eCSharpComponent.GET_BY_ID, "Get By ID"),
                new GeneratorComponent((int) eCSharpComponent.LIST_ALL, "List All"),
                new GeneratorComponent((int) eCSharpComponent.DELETE, "Delete"),
            };
        }

        public String GenerateCode(DatabaseEntity entity, Int32 componentId)
        {
            throw new NotImplementedException();
        }

        public string GenerateQuery(DatabaseEntity entity, Int32 componentId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
