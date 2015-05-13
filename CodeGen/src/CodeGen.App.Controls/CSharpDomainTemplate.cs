using System;
using CodeGen.Plugin.Base;

namespace CodeGen.App.Controls
{
    public sealed class CSharpDomainTemplate : IGeneratorTemplate
    {
        public String Name
        {
            get { return "C#"; }
        }

        public string Description
        {
            get { return "C# Domain Code Template"; }
        }

        public string Author
        {
            get { return "FrostDisk"; }
        }

        public string Version
        {
            get { return "1.0"; }
        }

        public DateTime UpdateVersion
        {
            get { return DateTime.Today; }
        }

        public string PluginUrl
        {
            get { return string.Empty; }
        }

        public string ReleaseNoteUrl
        {
            get { return string.Empty; }
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

        public void ShowOptionsForm()
        {
            
        }

        public String GenerateCode(DatabaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
