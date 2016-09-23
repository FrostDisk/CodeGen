using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Plugin.Base;

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
