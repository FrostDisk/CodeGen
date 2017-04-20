using CodeGen.Plugin.Base;
using CodeGen.Properties;
using CodeGen.Utils;
using NLog;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CodeGen.Core
{
    /// <summary>
    /// AspNetMvcCoreCodeTemplate
    /// </summary>
    public sealed class AspNetMvcCoreCodeTemplate : ICodeGeneratorTemplate
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private static string _defaultCsExtension = ".cs";
        private static string _defaultCshtmlExtension = ".cshtml";
        /// <summary>
        /// AuthorWebsiteUrl
        /// </summary>
        public string AuthorWebsiteUrl
        {
            get { return Resources.DefaultAuthorWebsiteUrl; }
        }

        /// <summary>
        /// CreatedBy
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
            get { return "ASP.NET MVC Core Models/View/Controller Code Template"; }
        }

        /// <summary>
        /// HaveOptions
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
        /// IsLoaded
        /// </summary>
        public bool IsLoaded
        {
            get; private set;
        }

        /// <summary>
        /// ReleaseNotesUrl
        /// </summary>
        public string ReleaseNotesUrl
        {
            get { return Resources.DefaultReleaseNotesUrl; }
        }

        /// <summary>
        /// Settings
        /// </summary>
        public PluginSettings Settings
        {
            get; private set;
        }

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return "ASP.NET MVC Core Code Template"; }
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
        /// Initializes a new instance of the <see cref="AspNetMvcCoreCodeTemplate"/> class.
        /// </summary>
        public AspNetMvcCoreCodeTemplate()
        {
            Settings = FormAspNetMvcCoreTemplateConfiguration.Instance.GetSettings();
        }

        #endregion

        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="component"></param>
        /// <returns></returns>
        public string Generate(DatabaseEntity entity, GeneratorComponent component)
        {
            if (FormAspNetMvcCoreTemplateConfiguration.Instance.ValidateForm())
            {
                AspNetMvcCoreGenerator generator = new AspNetMvcCoreGenerator(Settings, entity);

                switch (component.Id)
                {
                    case (int)eAspNetMvcCoreTemplateComponent.MODEL: { return generator.GenerateCodeModel(); }
                    case (int)eAspNetMvcCoreTemplateComponent.CONTROLLER: { return generator.GenerateCodeController(); }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_CREATE: { return generator.GenerateViewCreate(); }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_DELETE: { return generator.GenerateViewDelete(); }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_DETAILS: { return generator.GenerateViewDetails(); }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_EDIT: { return generator.GenerateViewEdit(); }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_INDEX: { return generator.GenerateViewIndex(); }
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// GenerateFileName
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="component"></param>
        /// <returns></returns>
        public string GenerateFileName(DatabaseEntity entity, GeneratorComponent component)
        {
            if (FormAspNetMvcCoreTemplateConfiguration.Instance.ValidateForm(false))
            {
                AspNetMvcCoreGenerator generator = new AspNetMvcCoreGenerator(Settings, entity);

                switch (component.Id)
                {
                    case (int)eAspNetMvcCoreTemplateComponent.MODEL: { return generator.ModelClassName + _defaultCsExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.CONTROLLER: { return generator.ControllerClassName + _defaultCsExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_CREATE: { return Settings[AspNetMvcCoreConstants.CREATE_VIEWNAME].Value + _defaultCshtmlExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_DELETE: { return Settings[AspNetMvcCoreConstants.DELETE_VIEWNAME].Value + _defaultCshtmlExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_DETAILS: { return Settings[AspNetMvcCoreConstants.DETAILS_VIEWNAME].Value + _defaultCshtmlExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_EDIT: { return Settings[AspNetMvcCoreConstants.EDIT_VIEWNAME].Value + _defaultCshtmlExtension; }
                    case (int)eAspNetMvcCoreTemplateComponent.VIEW_INDEX: { return Settings[AspNetMvcCoreConstants.INDEX_VIEWNAME].Value + _defaultCshtmlExtension; }

                }
            }

            return string.Empty;
        }

        /// <summary>
        /// GetComponents
        /// </summary>
        /// <returns></returns>
        public List<GeneratorComponent> GetComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.MODEL, "Model Class", _defaultCsExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.CONTROLLER, "Controller Class", _defaultCsExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.VIEW_CREATE, "Create View Page", _defaultCshtmlExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.VIEW_DELETE, "Delete View Page", _defaultCshtmlExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.VIEW_DETAILS, "Details View Page", _defaultCshtmlExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.VIEW_EDIT, "Edit View Page", _defaultCshtmlExtension),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.VIEW_INDEX, "Index View Page", _defaultCshtmlExtension),
            };
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="projectName"></param>
        public void Load(string projectName)
        {
            FormAspNetMvcCoreTemplateConfiguration.Instance.ReplaceMyProject(projectName);
            IsLoaded = true;
        }

        /// <summary>
        /// ShowOptionsForm
        /// </summary>
        /// <returns></returns>
        public bool ShowOptionsForm()
        {
            var result = FormAspNetMvcCoreTemplateConfiguration.Instance.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings = FormAspNetMvcCoreTemplateConfiguration.Instance.GetSettings();
                return true;
            }
            return false;
        }

        /// <summary>
        /// UpdateSettings
        /// </summary>
        /// <param name="settings"></param>
        public void UpdateSettings(PluginSettings settings)
        {
            foreach (PluginSettingValue settingValue in settings)
            {
                FormAspNetMvcCoreTemplateConfiguration.Instance.UpdateSetting(settingValue.Key, settingValue.Value);
            }

            Settings = FormAspNetMvcCoreTemplateConfiguration.Instance.GetSettings();
        }
    }
}
