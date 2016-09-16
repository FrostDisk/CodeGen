using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Core
{
    internal class AspNetMvcCoreGenerator
    {
        /// <summary>
        /// Settings
        /// </summary>
        public PluginSettings Settings { get; private set; }

        /// <summary>
        /// Entity
        /// </summary>
        public DatabaseEntity Entity { get; private set; }

        /// <summary>
        /// CleanEntityName
        /// </summary>
        public string CleanEntityName { get; private set; }

        public AspNetMvcCoreGenerator(PluginSettings settings, DatabaseEntity entity)
        {
            Settings = settings;
            Entity = entity;

            CleanEntityName = StringHelper.ConvertToSafeCodeName(StringHelper.RemovePrefix(entity.Name)).Replace("_", string.Empty);
        }
    }
}
