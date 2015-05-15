using System;
using System.Collections.Generic;
using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public sealed class CSharpBaseTemplate : IGeneratorTemplate
    {
        public String Name
        {
            get { return "C# Base Code Template"; }
        }

        public string Description
        {
            get { return "C# Domain/DataAccess Code Template"; }
        }

        public string LanguageCode
        {
            get { return "CSharp"; }
        }

        public String FileExtension
        {
            get { return ".cs"; }
        }

        public Boolean HaveOptions
        {
            get { return true; }
        }

        public bool HaveCodeComponents
        {
            get { return true; }
        }

        public bool HaveQueryComponents
        {
            get { return true; }
        }

        public void ShowOptionsForm()
        {
            FormCSharpCodeConfiguration form = new FormCSharpCodeConfiguration();
            form.ShowDialog();
        }

        public List<GeneratorComponent> GetCodeComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eCSharpComponent.DOMAIN, "Domain"),
                new GeneratorComponent((int) eCSharpComponent.DATA_ACCESS, "Data Access"),
            };
        }

        public List<GeneratorComponent> GetQueryComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent((int) eCSharpComponent.SAVE, "Save"),
                new GeneratorComponent((int) eCSharpComponent.GET_BY_ID, "Get By ID"),
                new GeneratorComponent((int) eCSharpComponent.LIST_ALL, "List All"),
                new GeneratorComponent((int) eCSharpComponent.DELETE, "Delete"),
            };
        }

        public String GenerateCode(DatabaseEntity entity, Int32 componentId)
        {
            throw new NotImplementedException();
        }

        public string GenerateQuery(DatabaseEntity entity, Int32 componentId)
        {
            throw new NotImplementedException();
        }
    }
}
