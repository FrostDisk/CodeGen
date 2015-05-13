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

        String Author { get; }

        String Version { get; }

        DateTime UpdateVersion { get; }

        String PluginUrl { get; }

        String ReleaseNoteUrl { get; }
    }
}
