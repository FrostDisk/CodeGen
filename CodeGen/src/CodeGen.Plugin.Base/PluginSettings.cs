using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// PluginSettings
    /// </summary>
    [Serializable]
    public class PluginSettings : List<PluginSettingValue>
    {
        /// <summary>
        /// PluginSettingValue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public PluginSettingValue this[string key]
        {
            get { return this.FirstOrDefault(t => t.Key == key); }
        }
    }
}
