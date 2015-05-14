using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IGeneratorTemplate : IPluginBase
    {
        String LanguageCode { get; }

        String FileExtension { get; }

        Boolean HaveOptions { get; }

        Boolean HaveCodeComponents { get; }

        Boolean HaveQueryComponents { get; }

        void ShowOptionsForm();

        List<GeneratorComponent> GetCodeComponents();

        List<GeneratorComponent> GetQueryComponents();

        String GenerateCode(DatabaseEntity entity, Int32 componentId);

        String GenerateQuery(DatabaseEntity entity, Int32 componentId);
    }
}
