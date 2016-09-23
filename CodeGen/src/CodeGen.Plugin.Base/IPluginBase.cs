﻿namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IPluginBase
    /// </summary>
    public interface IPluginBase : IPluginTypeBase
    {
        /// <summary>
        /// Settings
        /// </summary>
        PluginSettings Settings { get; }

        /// <summary>
        /// UpdateSettings
        /// </summary>
        /// <param name="settings"></param>
        void UpdateSettings(PluginSettings settings);
    }
}
