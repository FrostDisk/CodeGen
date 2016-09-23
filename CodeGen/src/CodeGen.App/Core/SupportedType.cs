﻿using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    /// <summary>
    /// SupportedType
    /// </summary>
    public class SupportedType
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Guid
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Item
        /// </summary>
        public IPluginBase Item { get; set; }
    }
}
