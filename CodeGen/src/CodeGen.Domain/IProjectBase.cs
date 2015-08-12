namespace CodeGen.Domain
{
    /// <summary>
    /// Base Interface for Projects classes
    /// </summary>
    public interface IProjectBase
    {
        /// <summary>
        /// Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        int Version { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        EnumDatabaseTypes Type { get; set; }
    }
}
