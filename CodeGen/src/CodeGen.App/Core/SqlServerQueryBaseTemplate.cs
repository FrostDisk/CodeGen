using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Windows.Forms;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public sealed class SqlServerQueryBaseTemplate : IQueryGeneratorTemplate
    {
        #region properties

        public String Name
        {
            get { return "Sql Server Base Query Template"; }
        }

        public string Description
        {
            get { return "Sql Server Save/GetById/ListaAll Query Template"; }
        }

        public PluginSettings Settings { get; private set; }

        public string LanguageCode
        {
            get { return "SqlServer"; }
        }

        public String FileExtension
        {
            get { return ".sql"; }
        }

        public String FileNameFilter
        {
            get { return "SQL Server files (*.sql)|*.sql"; }
        }

        public Boolean HaveOptions
        {
            get { return true; }
        }

        public bool HaveComponents
        {
            get { return GetComponents().Count > 0; }
        }

        public Boolean IsLoaded { get; private set; }

        #endregion

        #region initialization

        public SqlServerQueryBaseTemplate()
        {
            Settings = FormBaseTemplateConfiguration.Instance.GetSettings();
        }

        #endregion

        #region methods

        public void UpdateSettings(PluginSettings settings)
        {
            foreach (PluginSettingValue settingValue in settings)
            {
                FormBaseTemplateConfiguration.Instance.UpdateSetting(settingValue.Key, settingValue.Value);
            }
        }

        public void Load(String projectName)
        {
            FormBaseTemplateConfiguration.Instance.ReplaceMyProject(projectName);
            IsLoaded = true;
        }

        public bool ShowOptionsForm()
        {
            var result = FormBaseTemplateConfiguration.Instance.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings = FormBaseTemplateConfiguration.Instance.GetSettings();
                return true;
            }
            return false;
        }

        public List<GeneratorComponent> GetComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eBaseTemplateComponent.SAVE, "Save"),
                new GeneratorComponent((int) eBaseTemplateComponent.GET_BY_ID, "GetByID"),
                new GeneratorComponent((int) eBaseTemplateComponent.LIST_ALL, "ListAll"),
                new GeneratorComponent((int) eBaseTemplateComponent.DELETE, "Delete"),
            };
        }

        public String GenerateFileName(DatabaseEntity entity, Int32 componentId)
        {
            return string.Empty;
        }

        public String Generate(DatabaseEntity entity, Int32 componentId)
        {
            return string.Empty;
        }

        #endregion
    }
}
