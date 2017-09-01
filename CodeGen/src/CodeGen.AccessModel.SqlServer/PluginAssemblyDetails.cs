using CodeGen.Plugin.Base;

namespace CodeGen.AccessModel.SqlServer
{
    /// <summary>
    /// PluginAssemblyDetails
    /// </summary>
    public class PluginAssemblyDetails : IAssemblyDetails
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return ProgramInfo.AssemblyTitle; }
        }

        /// <summary>
        /// Version
        /// </summary>
        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return ProgramInfo.AssemblyDescription; }
        }

        /// <summary>
        /// Author
        /// </summary>
        public string Author
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        /// <summary>
        /// Url
        /// </summary>
        public string Url
        {
            get { return "https://github.com/FrostDisk/CodeGen"; }
        }
    }
}
