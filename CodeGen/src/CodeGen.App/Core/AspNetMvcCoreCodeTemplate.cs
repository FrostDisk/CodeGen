using CodeGen.Plugin.Base;
using CodeGen.Properties;
using CodeGen.Utils;
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
            get { return "ASP.NET MVC Core Model/View/Controller Code Template"; }
        }

        /// <summary>
        /// FileExtension
        /// </summary>
        public string FileExtension
        {
            get { return ".cs"; }
        }

        /// <summary>
        /// FileNameFilter
        /// </summary>
        public string FileNameFilter
        {
            get { return "Visual C# Files (*.cs)|*.cs"; }
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
        /// LanguageCode
        /// </summary>
        public string LanguageCode
        {
            get { return "CSharp"; }
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
        /// <param name="componentId"></param>
        /// <returns></returns>
        public string Generate(DatabaseEntity entity, int componentId)
        {
            if (FormAspNetMvcCoreTemplateConfiguration.Instance.ValidateForm())
            {
                AspNetMvcCoreGenerator generator = new AspNetMvcCoreGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int)eAspNetMvcCoreTemplateComponent.MODEL:
                        {
                            return generator.GenerateCodeModel();
                        }

                    case (int)eAspNetMvcCoreTemplateComponent.CONTROLLER:
                        {
                            return generator.GenerateCodeController();
                        }
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// GenerateFileName
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="componentId"></param>
        /// <returns></returns>
        public string GenerateFileName(DatabaseEntity entity, int componentId)
        {
            if (FormAspNetMvcCoreTemplateConfiguration.Instance.ValidateForm(false))
            {
                AspNetMvcCoreGenerator generator = new AspNetMvcCoreGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int)eAspNetMvcCoreTemplateComponent.MODEL:
                        {
                            return generator.ModelClassName + FileExtension;
                        }

                    case (int)eAspNetMvcCoreTemplateComponent.CONTROLLER:
                        {
                            return generator.ControllerClassName + FileExtension;
                        }
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
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.MODEL, "Model Class"),
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.CONTROLLER, "Controller Class"),
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
        }
    }
}
