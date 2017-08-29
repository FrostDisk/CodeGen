using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    /// <summary>
    /// PluginAssembly
    /// </summary>
    [Serializable]
    public class PluginAssembly : IPluginAssembly
    {
        /// <summary>
        /// Guid
        /// </summary>
        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [XmlAttribute("Version")]
        public string Version { get; set; }

        /// <summary>
        /// File
        /// </summary>
        [XmlAttribute("File")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        [XmlElement("Author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [XmlElement("Url")]
        public string Url { get; set; }

        /// <summary>
        /// DateInstalled
        /// </summary>
        [XmlElement("DateInstalled")]
        public DateTime DateInstalled { get; set; }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        [XmlIgnore]
        public bool IsValid { get; set; }

        /// <summary>
        /// Components
        /// </summary>
        [XmlArray("Components"), XmlArrayItem("Component")]
        public List<PluginComponent> Components { get; set; }

        /// <summary>
        /// Gets or sets the assembly instance.
        /// </summary>
        [XmlIgnore]
        public Assembly AssemblyInstance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        [XmlIgnore]
        public bool IsLoaded { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginAssembly"/> class.
        /// </summary>
        public PluginAssembly()
        {
            Components = new List<PluginComponent>();
            IsLoaded = false;
        }
    }
}
