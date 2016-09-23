using System.Drawing;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IPluginTypeBase
    /// </summary>
    public interface IPluginTypeBase
    {
        /// <summary>
        /// Title
        /// </summary>
        string Title { get; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        string CreatedBy { get; }

        /// <summary>
        /// Icon
        /// </summary>
        Image Icon { get; }

        /// <summary>
        /// Description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Version
        /// </summary>
        string Version { get; }

        /// <summary>
        /// ReleaseNotesUrl
        /// </summary>
        string ReleaseNotesUrl { get; }

        /// <summary>
        /// AuthorWebsiteUrl
        /// </summary>
        string AuthorWebsiteUrl { get; }
    }
}
