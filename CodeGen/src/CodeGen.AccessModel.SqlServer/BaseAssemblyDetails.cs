using CodeGen.Plugin.Base;

namespace CodeGen.AccessModel.SqlServer
{
    /// <summary>
    /// Base Class with common information for Base plugins
    /// </summary>
    /// <seealso cref="IAssemblyDetails" />
    public class BaseAssemblyDetails : IAssemblyDetails
    {
        /// <summary>
        /// Assembly Title
        /// </summary>
        public string Title
        {
            get { return ProgramInfo.AssemblyTitle; }
        }

        /// <summary>
        /// Assembly Version
        /// </summary>
        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        /// <summary>
        /// Assembly Description
        /// </summary>
        public string Description
        {
            get { return ProgramInfo.AssemblyDescription; }
        }

        /// <summary>
        /// Assembly Company
        /// </summary>
        public string Author
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        /// <summary>
        /// Assembly Author Url
        /// </summary>
        public string Url
        {
            get { return "https://github.com/FrostDisk/CodeGen"; }
        }
    }
}
