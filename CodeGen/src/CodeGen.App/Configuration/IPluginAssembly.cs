using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeGen.Configuration
{
    /// <summary>
    /// IPluginAssembly
    /// </summary>
    public interface IPluginAssembly
    {
        /// <summary>
        /// Guid
        /// </summary>
        string Guid { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// File
        /// </summary>
        string File { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// DateInstalled
        /// </summary>
        DateTime DateInstalled { get; set; }

        /// <summary>
        /// IsValid
        /// </summary>
        bool IsValid { get; set; }

        /// <summary>
        /// Components
        /// </summary>
        List<PluginComponent> Components { get; set; }

        /// <summary>
        /// Gets or sets the assembly instance.
        /// </summary>
        Assembly AssemblyInstance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        bool IsLoaded { get; set; }
    }
}
