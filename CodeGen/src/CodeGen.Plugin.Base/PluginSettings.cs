using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGen.Plugin.Base
{
    [Serializable]
    public class PluginSettings : List<PluginSettingValue>
    {
        public PluginSettingValue this[string key]
        {
            get { return this.FirstOrDefault(t => t.Key == key); }
        }
    }
}
