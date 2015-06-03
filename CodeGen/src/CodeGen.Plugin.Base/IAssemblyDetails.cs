using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IAssemblyDetails
    {
        string Title { get; }

        string Version { get; }

        string Description { get; }

        string Author { get; }

        string Url { get; }
    }
}
