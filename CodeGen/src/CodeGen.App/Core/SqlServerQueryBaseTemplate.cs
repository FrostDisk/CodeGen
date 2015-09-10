using CodeGen.Plugin.Base;
using CodeGen.Properties;
using CodeGen.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CodeGen.Core
{
    public sealed class SqlServerQueryBaseTemplate : IQueryGeneratorTemplate
    {
        #region properties

        public string Title
        {
            get { return "Sql Server Base Query Template"; }
        }

        public string CreatedBy
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        public Image Icon
        {
            get { return null; }
        }

        public string Description
        {
            get { return "Sql Server Save/GetById/ListaAll Query Template"; }
        }

        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        public string ReleaseNotesUrl
        {
            get { return Resources.DefaultReleaseNotesUrl; }
        }

        public string AuthorWebsiteUrl
        {
            get { return Resources.DefaultAuthorWebsiteUrl; }
        }

        public PluginSettings Settings { get; private set; }

        public string LanguageCode
        {
            get { return "SqlServer"; }
        }

        public string FileExtension
        {
            get { return ".sql"; }
        }

        public string FileNameFilter
        {
            get { return "SQL Server files (*.sql)|*.sql"; }
        }

        public bool HaveOptions
        {
            get { return true; }
        }

        public bool IsLoaded { get; private set; }

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

        public void Load(string projectName)
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

        public string GenerateFileName(DatabaseEntity entity, int componentId)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm(false))
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int)eBaseTemplateComponent.SAVE:
                        {
                            return generator.SaveStoredProcedureName + FileExtension;
                        }

                    case (int)eBaseTemplateComponent.GET_BY_ID:
                        {
                            return generator.GetByIdStoredProcedureName + FileExtension;
                        }

                    case (int)eBaseTemplateComponent.LIST_ALL:
                        {
                            return generator.ListAllStoredProcedureName + FileExtension;
                        }

                    case (int)eBaseTemplateComponent.DELETE:
                        {
                            return generator.DeleteStoredProcedureName + FileExtension;
                        }
                }
            }

            return string.Empty;
        }

        public string Generate(DatabaseEntity entity, int componentId)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm())
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int)eBaseTemplateComponent.SAVE:
                        {
                            return generator.GenerateScriptSave();
                        }

                    case (int)eBaseTemplateComponent.GET_BY_ID:
                        {
                            return generator.GenerateScriptGetById();
                        }

                    case (int)eBaseTemplateComponent.LIST_ALL:
                        {
                            return generator.GenerateScriptListAll();
                        }

                    case (int)eBaseTemplateComponent.DELETE:
                        {
                            return generator.GenerateScriptDelete();
                        }
                }
            }

            return string.Empty;
        }

        #endregion
    }
}
