using System;
using System.ComponentModel;
using CodeGen.Domain;
using CodeGen.Plugin.Base;

namespace CodeGen.Controls
{
    public interface IGeneratorUserControl : IBaseUserControl, ISettingsUserControl
    {
        Project Project { get; set; }

        event EventHandler OnControlUpdate;

        IGeneratorTemplate ActiveTemplate { get; }
    }
}
