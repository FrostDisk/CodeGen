using CodeGen.Plugin.Base;

namespace CodeGen.Core
{
    public class SupportedType
    {
        public string Name { get; set; }

        public string Guid { get; set; }

        public string Type { get; set; }

        public IPluginBase Item { get; set; }
    }
}
