using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Plugin.Base;

namespace CodeGen.Utils
{
    public class BaseAssemblyDetails : IAssemblyDetails
    {
        public string Title
        {
            get { return ProgramInfo.AssemblyTitle; }
        }

        public string Version
        {
            get { return ProgramInfo.AssemblyVersion; }
        }

        public string Description
        {
            get { return ProgramInfo.AssemblyDescription; }
        }

        public string Author
        {
            get { return ProgramInfo.AssemblyCompany; }
        }

        public string Url
        {
            get { return "https://github.com/FrostDisk/CodeGen"; }
        }
    }
}
