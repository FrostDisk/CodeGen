using CodeGen.Domain;
using CodeGen.Generator.Default.Core;
using CodeGen.Plugin.Base;
using CodeGen.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CodeGen.Generator.Default
{
    /// <summary>
    /// SqlServerQueryBaseTemplate
    /// </summary>
    /// <seealso cref="IQueryGeneratorTemplate" />
    public sealed class SqlServerQueryBaseTemplate : IQueryGeneratorTemplate
    {
        #region properties

         /// <summary>
        /// File Extension
        /// </summary>
        private const string _defaultFileExtension = ".sql";

        /// <summary>
        /// Author Website Url
        /// </summary>
        public string AuthorWebsiteUrl
        {
            get { return Resources.DefaultAuthorWebsiteUrl; }
        }

        /// <summary>
        /// Created By
        /// </summary>
        public string CreatedBy
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return "Sql Server Save/GetById/ListaAll Query Template"; }
        }

        /// <summary>
        /// CompatibleControllers
        /// </summary>
        public List<string> CompatibleControllers
        {
            get { return new List<string> { EnumDatabaseTypes.SqlServer.ToString("G") }; }
        }

        /// <summary>
        /// Have Options
        /// </summary>
        public bool HaveOptions
        {
            get { return true; }
        }

        /// <summary>
        /// Icon
        /// </summary>
        public Image Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Is Loaded
        /// </summary>
        public bool IsLoaded { get; private set; }

        /// <summary>
        /// Release Notes Url
        /// </summary>
        public string ReleaseNotesUrl
        {
            get { return Resources.DefaultReleaseNotesUrl; }
        }

        /// <summary>
        /// Settings
        /// </summary>
        public PluginSettings Settings { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return "Sql Server Base Query Template"; }
        }

        /// <summary>
        /// Version
        /// </summary>
        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerQueryBaseTemplate"/> class.
        /// </summary>
        public SqlServerQueryBaseTemplate()
        {
            Settings = FormBaseTemplateConfiguration.Instance.GetSettings();
        }

        #endregion

        #region methods

        /// <summary>
        /// Generates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="component">The component identifier.</param>
        /// <returns></returns>
        public string Generate(DatabaseEntity entity, GeneratorComponent component)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm())
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (component.Id)
                {
                    case (int)eBaseTemplateComponent.SAVE: { return generator.GenerateScriptSave(); }
                    case (int)eBaseTemplateComponent.GET_BY_ID: { return generator.GenerateScriptGetById(); }
                    case (int)eBaseTemplateComponent.LIST_ALL: { return generator.GenerateScriptListAll(); }
                    case (int)eBaseTemplateComponent.DELETE: { return generator.GenerateScriptDelete(); }
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Generates the name of the file.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="component">The component identifier.</param>
        /// <returns></returns>
        public string GenerateFileName(DatabaseEntity entity, GeneratorComponent component)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm(false))
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (component.Id)
                {
                    case (int)eBaseTemplateComponent.SAVE: { return generator.SaveStoredProcedureName + _defaultFileExtension; }
                    case (int)eBaseTemplateComponent.GET_BY_ID: { return generator.GetByIdStoredProcedureName + _defaultFileExtension; }
                    case (int)eBaseTemplateComponent.LIST_ALL: { return generator.ListAllStoredProcedureName + _defaultFileExtension; }
                    case (int)eBaseTemplateComponent.DELETE: { return generator.DeleteStoredProcedureName + _defaultFileExtension; }
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the components.
        /// </summary>
        /// <returns></returns>
        public List<GeneratorComponent> GetComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eBaseTemplateComponent.SAVE, "Save Stored Procedure", _defaultFileExtension),
                new GeneratorComponent((int) eBaseTemplateComponent.GET_BY_ID, "GetByID Stored Procedure", _defaultFileExtension),
                new GeneratorComponent((int) eBaseTemplateComponent.LIST_ALL, "ListAll Stored Procedure", _defaultFileExtension),
                new GeneratorComponent((int) eBaseTemplateComponent.DELETE, "Delete Stored Procedure", _defaultFileExtension),
            };
        }

        /// <summary>
        /// Loads the specified project name.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        public void Load(string projectName)
        {
            FormBaseTemplateConfiguration.Instance.ReplaceMyProject(projectName);
            IsLoaded = true;
        }

        /// <summary>
        /// Shows the options form.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void UpdateSettings(PluginSettings settings)
        {
            foreach (PluginSettingValue settingValue in settings)
            {
                FormBaseTemplateConfiguration.Instance.UpdateSetting(settingValue.Key, settingValue.Value);
            }

            Settings = FormBaseTemplateConfiguration.Instance.GetSettings();
        }

        #endregion
    }
}
