using System;
using CodeGen.Domain;
using CodeGen.Plugin.Base;

namespace CodeGen.Controls
{
    /// <summary>
    /// IGeneratorUserControl
    /// </summary>
    /// <seealso cref="IBaseUserControl" />
    /// <seealso cref="ISettingsUserControl" />
    public interface IGeneratorUserControl : IBaseUserControl, ISettingsUserControl
    {
        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        Project Project { get; set; }

        /// <summary>
        /// Occurs when [on control update].
        /// </summary>
        event EventHandler OnControlUpdate;

        /// <summary>
        /// Gets the active template.
        /// </summary>
        IGeneratorTemplate ActiveTemplate { get; }
    }
}
