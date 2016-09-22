namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IAssemblyDetails
    /// </summary>
    public interface IAssemblyDetails
    {
        /// <summary>
        /// Title
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Version
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Author
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Url
        /// </summary>
        string Url { get; }
    }
}
