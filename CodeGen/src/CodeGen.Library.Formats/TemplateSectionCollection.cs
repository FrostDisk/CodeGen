using System.Collections.Generic;
using System.Linq;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// TemplateSectionCollection
    /// </summary>
    public sealed class TemplateSectionCollection
    {
        private readonly List<TemplateSection> _sections = new List<TemplateSection>();

        /// <summary>
        /// Sections
        /// </summary>
        public IEnumerable<TemplateSection> Sections { get { return _sections; } }

        /// <summary>
        /// Gets the content of all valid.
        /// </summary>
        /// <returns></returns>
        public string GetAllContent(string separator = "")
        {
            return string.Join(separator, _sections.Where(section => section._isValidSection).Select(section => section.Content));
        }

        /// <summary>
        /// Finds the section.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <returns></returns>
        public TemplateSection FindSection(string sectionName)
        {
            return _sections.Find(seccion => seccion.SectionName.Equals(sectionName) && string.IsNullOrWhiteSpace(seccion.EndTag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSectionCollection"/> class.
        /// </summary>
        public TemplateSectionCollection()
        {
        }

        /// <summary>
        /// Adds the section.
        /// </summary>
        /// <param name="section">The section.</param>
        public void AddSection(TemplateSection section)
        {
            _sections.Add(section);
        }

        /// <summary>
        /// Removes the section.
        /// </summary>
        /// <param name="section">The section.</param>
        internal void RemoveSection(TemplateSection section)
        {
            _sections.Remove(section);
        }
    }
}
