using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IPluginBase
    {
        String Name { get; }

        String Description { get; }
    }
}
