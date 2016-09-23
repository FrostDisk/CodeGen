using System.Collections.Generic;
using System.Windows.Forms;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using System.Drawing;
using CodeGen.Properties;

namespace CodeGen.Core
{
    /// <summary>
    /// CSharpCodeBaseTemplate
    /// </summary>
    /// <seealso cref="ICodeGeneratorTemplate" />
    public sealed class CSharpCodeBaseTemplate : ICodeGeneratorTemplate
    {
        #region properties

        /// <summary>
        /// File Extension
        /// </summary>
        public string _defaultFileExtension = ".cs";

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
            get { return "C# Domain/DataAccess Code Template"; }
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
            get { return "C# Base Code Template"; }
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
        /// Initializes a new instance of the <see cref="CSharpCodeBaseTemplate"/> class.
        /// </summary>
        public CSharpCodeBaseTemplate()
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
                    case (int)eBaseTemplateComponent.DOMAIN: { return generator.GenerateCodeDomain(); }
                    case (int)eBaseTemplateComponent.DATA_ACCESS: { return generator.GenerateCodeDataAccess(); }
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
                    case (int)eBaseTemplateComponent.DOMAIN: { return generator.DomainClassName + _defaultFileExtension; }
                    case (int)eBaseTemplateComponent.DATA_ACCESS: { return generator.DataAccessClassName + _defaultFileExtension; }
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
                new GeneratorComponent((int) eBaseTemplateComponent.DOMAIN, "Domain", _defaultFileExtension),
                new GeneratorComponent((int) eBaseTemplateComponent.DATA_ACCESS, "Data Access", _defaultFileExtension),
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
        }

        #endregion
    }
}
