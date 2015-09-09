using System;
using System.Drawing;
using System.Xml.Serialization;
using CodeGen.Plugin.Base;

namespace CodeGen.Configuration
{
    [Serializable]
    public class PluginType : IPluginTypeBase
    {
        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("CreatedBy")]
        public string CreatedBy { get; set; }

        [XmlIgnore]
        public Image Icon { get; set; }

        [XmlElement("IconPath")]
        public string IconPath { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlElement("ReleaseNotesUrl")]
        public string ReleaseNotesUrl { get; set; }

        [XmlElement("AuthorWebsiteUrl")]
        public string AuthorWebsiteUrl { get; set; }

        [XmlElement("DateInstalled")]
        public DateTime DateInstalled { get; set; }

        [XmlAttribute("Class")]
        public string Class { get; set; }

        [XmlAttribute("Base")]
        public string Base { get; set; }

        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }

        [XmlAttribute("Enabled")]
        public bool Enabled { get; set; }

        [XmlIgnore]
        public IPluginBase PluginInstance { get; set; }

        [XmlIgnore]
        public bool IsLoaded { get; set; }

        public PluginType()
        {
            IsLoaded = false;
        }
    }
}
