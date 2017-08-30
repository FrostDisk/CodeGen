using NLog;
using System;
using System.Xml.Serialization;

namespace CodeGen.Configuration
{
    /// <summary>
    /// LogSettings
    /// </summary>
    [Serializable]
    public class LogSettings
    {
        /// <summary>
        /// Level
        /// </summary>
        [XmlElement("Level")]
        public string Level { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogSettings"/> class.
        /// </summary>
        public LogSettings()
        {
            Level = LogLevel.Info.Name;
        }
    }
}
