using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IGeneratorTemplate
    {
        string Name { get; }

        bool HaveOptions { get; }

        void ShowOptionsForm();

        
    }
}
