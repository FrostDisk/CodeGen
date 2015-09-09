using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Plugin.Base;

namespace CodeGen.Controls
{
    public interface ISettingsUserControl
    {
        PluginSettings Settings { get; }

        void UpdateSettings(PluginSettings settings);

        event EventHandler OnSettingsUpdate;
    }
}
