using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// DatabaseEntity
    /// </summary>
    public sealed class DatabaseEntity
    {
        /// <summary>
        /// Qualifier
        /// </summary>
        public string Qualifier { get; set; }

        /// <summary>
        /// Owner
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        public List<DatabaseEntityField> Fields { get; set; }

        /// <summary>
        /// DatabaseEntity
        /// </summary>
        public DatabaseEntity()
        {
            Fields = new List<DatabaseEntityField>();
        }
    }
}
