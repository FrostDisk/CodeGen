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
    public class PluginAssembly
    {
        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        [XmlAttribute("File")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [XmlAttribute("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        [XmlAttribute("Guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [XmlAttribute("Version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is base.
        /// </summary>
        [XmlAttribute("IsBase")]
        public bool IsBase { get; set; }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

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
        /// Gets or sets the types.
        /// </summary>
        [XmlArray("Components"), XmlArrayItem("Type")]
        public List<PluginType> Types { get; set; }

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
            Types = new List<PluginType>();
            IsLoaded = false;
        }
    }
}
