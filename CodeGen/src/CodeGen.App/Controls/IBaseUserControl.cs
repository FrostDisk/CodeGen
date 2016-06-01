namespace CodeGen.Controls
{
    /// <summary>
    /// IBaseUserControl
    /// </summary>
    /// <seealso cref="IBaseForm" />
    public interface IBaseUserControl : IBaseForm
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        bool IsLoaded { get; set; }
    }
}
