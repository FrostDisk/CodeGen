using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Windows.Forms;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public sealed class CSharpQueryBaseTemplate : IQueryGeneratorTemplate
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

        public String FileNameFilter
        {
            get { return "Visual C# Files (*.cs)|*.cs"; }
        }

        public Boolean HaveOptions
        {
            get { return true; }
        }

        public bool HaveComponents
        {
            get { return GetComponents().Count > 0; }
        }

        private FormCSharpCodeConfiguration _formConfiguration;

        #endregion

        #region initialization

        public CSharpQueryBaseTemplate()
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

        public List<GeneratorComponent> GetComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eCSharpComponent.DOMAIN, "Domain"),
                new GeneratorComponent((int) eCSharpComponent.DATA_ACCESS, "Data Access"),
            };
        }

        public String GenerateFileName(DatabaseEntity entity, Int32 componentId)
        {
            return string.Empty;
        }

        public String Generate(DatabaseEntity entity, Int32 componentId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
