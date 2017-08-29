using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    /// <summary>
    /// SupportedType
    /// </summary>
    public class SupportedPluginComponent
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
        /// Assembly
        /// </summary>
        public string Assembly { get; set; }

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
