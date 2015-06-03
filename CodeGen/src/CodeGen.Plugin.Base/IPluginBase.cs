using System;

namespace CodeGen.Plugin.Base
{
    public interface IPluginBase
    {
        String Title { get; }

        String Description { get; }

        String Version { get; }

        PluginSettings Settings { get; }

        void UpdateSettings(PluginSettings settings);
    }
}
