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
            get { return false; }
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
            
        }

        public List<GeneratorComponent> GetCodeComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent(1, "Domain"),
                new GeneratorComponent(2, "Data Access"),
            };
        }

        public List<GeneratorComponent> GetQueryComponents()
        {
            return new List<GeneratorComponent>
            {
                new GeneratorComponent(1, "Save"),
                new GeneratorComponent(2, "Get By ID"),
                new GeneratorComponent(3, "List All"),
                new GeneratorComponent(4, "Delete"),
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
