using System;
using System.Drawing;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;

namespace CodeGen.Configuration
{
    /// <summary>
    /// PluginType
    /// </summary>
    /// <seealso cref="CodeGen.Plugin.Base.IPluginTypeBase" />
    [Serializable]
    public class PluginType : IPluginTypeBase
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        [XmlElement("CreatedBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [XmlIgnore]
        public Image Icon { get; set; }

        /// <summary>
        /// Gets or sets the icon path.
        /// </summary>
        [XmlElement("IconPath")]
        public string IconPath { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [XmlAttribute("Version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the release notes URL.
        /// </summary>
        [XmlElement("ReleaseNotesUrl")]
        public string ReleaseNotesUrl { get; set; }

        /// <summary>
        /// Gets or sets the author website URL.
        /// </summary>
        [XmlElement("AuthorWebsiteUrl")]
        public string AuthorWebsiteUrl { get; set; }

        /// <summary>
        /// Gets or sets the date installed.
        /// </summary>
        [XmlElement("DateInstalled")]
        public DateTime DateInstalled { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        [XmlAttribute("Class")]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        [XmlAttribute("Base")]
        public string Base { get; set; }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PluginType"/> is enabled.
        /// </summary>
        [XmlAttribute("Enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the plugin instance.
        /// </summary>
        [XmlIgnore]
        public IPluginBase PluginInstance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        [XmlIgnore]
        public bool IsLoaded { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginType"/> class.
        /// </summary>
        public PluginType()
        {
            IsLoaded = false;
        }
    }
}
