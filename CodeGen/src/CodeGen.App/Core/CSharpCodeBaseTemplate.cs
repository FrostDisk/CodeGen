﻿using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Windows.Forms;
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen.Core
{
    public sealed class CSharpCodeBaseTemplate : ICodeGeneratorTemplate
    {
        #region properties

        public String Title
        {
            get { return "C# Base Code Template"; }
        }

        public string Description
        {
            get { return "C# Domain/DataAccess Code Template"; }
        }

        public String Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        public PluginSettings Settings { get; private set; }

        public String LanguageCode
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

        public Boolean HaveComponents
        {
            get { return GetComponents().Count > 0; }
        }

        public Boolean IsLoaded { get; private set; }

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
                new GeneratorComponent((int) eBaseTemplateComponent.DOMAIN, "Domain"),
                new GeneratorComponent((int) eBaseTemplateComponent.DATA_ACCESS, "Data Access"),
            };
        }

        public String GenerateFileName(DatabaseEntity entity, Int32 componentId)
        {
            if (FormBaseTemplateConfiguration.Instance.ValidateForm(false))
            {
                BaseGenerator generator = new BaseGenerator(Settings, entity);

                switch (componentId)
                {
                    case (int) eBaseTemplateComponent.DOMAIN:
                    {
                        return string.Format("{0}{1}", generator.DomainClassName, FileExtension);
                    }

                    case (int) eBaseTemplateComponent.DATA_ACCESS:
                    {
                        return string.Format("{0}{1}", generator.DataAccessClassName, FileExtension);
                    }
                }
            }

            return string.Empty;
        }

        public String Generate(DatabaseEntity entity, Int32 componentId)
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
