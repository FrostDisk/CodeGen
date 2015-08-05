using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Plugin.Base
{
    public interface IPluginTypeBase
    {
        String Title { get; }

        String CreatedBy { get; }

        Image Icon { get; }

        String Description { get; }

        String Version { get; }

        String ReleaseNotesUrl { get; }

        String AuthorWebsiteUrl { get; }
    }
}
