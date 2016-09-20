using CodeGen.Plugin.Base;
using CodeGen.Properties;
using CodeGen.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CodeGen.Core
{
    public sealed class AspNetMvcCoreCodeTemplate : ICodeGeneratorTemplate
    {
        #region properties

        public string AuthorWebsiteUrl
        {
            get { return Resources.DefaultAuthorWebsiteUrl; }
        }

        public string CreatedBy
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        public string Description
        {
            get { return "ASP.NET MVC Core Model/View/Controller Code Template"; }
        }

        public string FileExtension
        {
            get { return ".cs"; }
        }

        public string FileNameFilter
        {
            get { return "Visual C# Files (*.cs)|*.cs"; }
        }

        public bool HaveOptions
        {
            get { return true; }
        }

        public Image Icon
        {
            get { return null; }
        }

        public bool IsLoaded
        {
            get; private set;
        }

        public string LanguageCode
        {
            get { return "CSharp"; }
        }

        public string ReleaseNotesUrl
        {
            get { return Resources.DefaultReleaseNotesUrl; }
        }

        public PluginSettings Settings
        {
            get; private set;
        }

        public string Title
        {
            get { return "ASP.NET MVC Core Code Template"; }
        }

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
            Settings = FormBaseTemplateConfiguration.Instance.GetSettings();
        }

        #endregion

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

                    //case (int)eBaseTemplateComponent.DATA_ACCESS:
                    //    {
                    //        return generator.GenerateCodeDataAccess();
                    //    }
                }
            }

            return string.Empty;
        }

        public string GenerateFileName(DatabaseEntity entity, int componentId)
        {
            if (FormAspNetMvcCoreTemplateConfiguration.Instance.ValidateForm(false))
            {
                AspNetMvcCoreGenerator generator = new AspNetMvcCoreGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int)eAspNetMvcCoreTemplateComponent.MODEL:
                        {
                            return generator.CleanEntityName + FileExtension;
                        }

                    case (int)eAspNetMvcCoreTemplateComponent.CONTROLLER:
                        {
                            return generator.CleanEntityName + FileExtension;
                        }
                }
            }

            return string.Empty;
        }

        public List<GeneratorComponent> GetComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.MODEL, "Model"),
                //new GeneratorComponent((int) eAspNetMvcCoreTemplateComponent.CONTROLLER, "Controller"),
            };
        }

        public void Load(string projectName)
        {
            FormAspNetMvcCoreTemplateConfiguration.Instance.ReplaceMyProject(projectName);
            IsLoaded = true;
        }

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

        public void UpdateSettings(PluginSettings settings)
        {
            foreach (PluginSettingValue settingValue in settings)
            {
                FormAspNetMvcCoreTemplateConfiguration.Instance.UpdateSetting(settingValue.Key, settingValue.Value);
            }
        }
    }
}
