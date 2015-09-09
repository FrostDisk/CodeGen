using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IGeneratorTemplate : IPluginBase
    {
        String LanguageCode { get; }

        String FileExtension { get; }

        String FileNameFilter { get; }

        Boolean HaveOptions { get; }

        Boolean IsLoaded { get; }

        void Load(String projectName);

        bool ShowOptionsForm();

        List<GeneratorComponent> GetComponents();

        String GenerateFileName(DatabaseEntity entity, Int32 componentId);

        String Generate(DatabaseEntity entity, Int32 componentId);
    }
}
