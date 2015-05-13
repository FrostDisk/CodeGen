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

        void ShowOptionsForm();

        String GenerateCode(DatabaseEntity entity);
    }
}
