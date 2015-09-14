using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Windows.Forms;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using System.Drawing;
using CodeGen.Properties;

namespace CodeGen.Core
{
    public sealed class CSharpCodeBaseTemplate : ICodeGeneratorTemplate
    {
        #region properties

        public string Title
        {
            get { return "C# Base Code Template"; }
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
            get { return "C# Domain/DataAccess Code Template"; }
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
            get { return "CSharp"; }
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

        public bool IsLoaded { get; private set; }

        #endregion

        #region initialization

        public CSharpCodeBaseTemplate()
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
                new GeneratorComponent((int) eBaseTemplateComponent.DOMAIN, "Domain"),
                new GeneratorComponent((int) eBaseTemplateComponent.DATA_ACCESS, "Data Access"),
            };
        }

        public string GenerateFileName(DatabaseEntity entity, int componentId)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm(false))
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int) eBaseTemplateComponent.DOMAIN:
                    {
                        return generator.DomainClassName + FileExtension;
                    }

                    case (int) eBaseTemplateComponent.DATA_ACCESS:
                    {
                        return generator.DataAccessClassName + FileExtension;
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
                    case (int) eBaseTemplateComponent.DOMAIN:
                    {
                        return generator.GenerateCodeDomain();
                    }

                    case (int) eBaseTemplateComponent.DATA_ACCESS:
                    {
                        return generator.GenerateCodeDataAccess();
                    }
                }
            }

            return string.Empty;
        }

        #endregion
    }
}
