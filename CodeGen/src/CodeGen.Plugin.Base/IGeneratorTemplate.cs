using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    public interface IGeneratorTemplate : IPluginBase
    {
        string LanguageCode { get; }

        string FileExtension { get; }

        string FileNameFilter { get; }

        bool HaveOptions { get; }

        bool IsLoaded { get; }

        void Load(string projectName);

        bool ShowOptionsForm();

        List<GeneratorComponent> GetComponents();

        string GenerateFileName(DatabaseEntity entity, int componentId);

        string Generate(DatabaseEntity entity, int componentId);
    }
}
