using System.Drawing;

namespace CodeGen.Plugin.Base
{
    public interface IPluginTypeBase
    {
        string Title { get; }

        string CreatedBy { get; }

        Image Icon { get; }

        string Description { get; }

        string Version { get; }

        string ReleaseNotesUrl { get; }

        string AuthorWebsiteUrl { get; }
    }
}
