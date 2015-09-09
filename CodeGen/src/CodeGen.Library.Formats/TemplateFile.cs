namespace CodeGen.Library.Formats
{
    /// <summary>
    /// TemplateFile
    /// </summary>
    public sealed class TemplateFile : TemplateSection
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="TemplateFile" /> class from being created.
        /// </summary>
        /// <param name="templateType">Type of the template.</param>
        /// <param name="templateContent">Content of the template.</param>
        private TemplateFile(TemplateType templateType, string templateContent)
            : base(templateContent)
        {
            SectionType = templateType;
        }

        /// <summary>
        /// Factory method to create new <see cref="TemplateFile" />
        /// </summary>
        /// <param name="templateType">Template Type (CS or ASPX)</param>
        /// <param name="templateContent">Content of the template.</param>
        /// <returns></returns>
        public static TemplateFile LoadTemplate(TemplateType templateType, string templateContent)
        {
            return new TemplateFile(templateType, templateContent);
        }
    }
}
