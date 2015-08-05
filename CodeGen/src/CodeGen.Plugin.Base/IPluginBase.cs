using System;
using System.Drawing;

namespace CodeGen.Plugin.Base
{
    public interface IPluginBase : IPluginTypeBase
    {
        PluginSettings Settings { get; }

        void UpdateSettings(PluginSettings settings);
    }
}
