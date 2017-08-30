using CodeGen.Plugin.Base;
using System;

namespace CodeGen.Controls
{
    /// <summary>
    /// ISettingsUserControl
    /// </summary>
    public interface ISettingsUserControl
    {
        /// <summary>
        /// Gets the settings.
        /// </summary>
        PluginSettings Settings { get; }

        /// <summary>
        /// Updates the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        void UpdateSettings(PluginSettings settings);

        /// <summary>
        /// Occurs when [on settings update].
        /// </summary>
        event EventHandler OnSettingsUpdate;
    }
}
