using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// Template Section, to manage dynamic content using recursive elements inside
    /// the section
    /// </summary>
    public class TemplateSection
    {
        internal bool _isValidSection { get; set; }

        internal StringBuilder _contentBuilder { get; set; }

        private TemplateSection _parent { get; set; }

        /// <summary>
        /// Begin Section Tag, like /*-- begin section NAME [as VARIABLE] */
        /// </summary>
        public string BeginTag { get; private set; }

        /// <summary>
        /// End Section Tag, like /*-- end section NOMBRE */
        /// </summary>
        public string EndTag { get; private set; }

        /// <summary>
        /// First-Character Index for Begin Section Tag
        /// </summary>
        public int BeginTagIndex { get; private set; }

        /// <summary>
        /// First-Character Index for End Section Tag
        /// </summary>
        public int EndTagIndex { get; private set; }

        /// <summary>
        /// Character Index from the begining of the inside content
        /// </summary>
        public int FromContentIndex { get; private set; }

        /// <summary>
        /// Character length of the content
        /// </summary>
        public int ContentLength { get; private set; }

        /// <summary>
        /// Section Name
        /// </summary>
        public string SectionName { get; private set; }

        /// <summary>
        /// Local Variable Name for the Section
        /// </summary>
        public string SectionVariable { get; private set; }

        /// <summary>
        /// Section type (ASPX, CS o SQL), todas las sectionList hijas mantienen el mismo tipo
        /// </summary>
        public TemplateType SectionType { get; protected set; }

        /// <summary>
        /// Section Content (between section tags)
        /// </summary>
        public string Content { get { return _contentBuilder.ToString(); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSection"/> class.
        /// </summary>
        internal TemplateSection()
        {
            _isValidSection = false;
            _contentBuilder = new StringBuilder();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSection"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        internal TemplateSection(string content)
        {
            _isValidSection = false;
            _contentBuilder = new StringBuilder(content);
        }

        /// <summary>
        /// Replace some tag with some string
        /// </summary>
        /// <param name="tagName">Tag Name, doesn't need the {} brackets</param>
        /// <param name="content">Text to replace</param>
        /// <param name="isLocalVariable">if set to <c>true</c> [is Local Variable].</param>
        public void ReplaceTag(string tagName, string content, bool isLocalVariable = true)
        {
            _contentBuilder.Replace(GetReplaceTag(tagName, isLocalVariable), content);
        }

        /// <summary>
        /// Replace some tag with the content of other section
        /// </summary>
        /// <param name="tagName">Tag Name, doesn't need the {} brackets</param>
        /// <param name="section">Section to replace</param>
        /// <param name="isLocalVariable">if set to <c>true</c> [is local variable].</param>
        public void ReplaceTag(string tagName, TemplateSection section, bool isLocalVariable = true)
        {
            if (section._isValidSection)
            {
                _contentBuilder.Replace(GetReplaceTag(tagName, isLocalVariable), section.Content);
            }
        }

        /// <summary>
        /// Replace some tag with a list of sections
        /// </summary>
        /// <param name="tagName">Tag Name, doesn't need the {} brackets</param>
        /// <param name="sectionList">Section list with all the sections to replace</param>
        /// <param name="isLocalVariable">if set to <c>true</c> [is local variable].</param>
        public void ReplaceTag(string tagName, TemplateSectionCollection sectionList, bool isLocalVariable = true)
        {
            _contentBuilder.Replace(GetReplaceTag(tagName, isLocalVariable), sectionList.GetAllContent());
        }

        /// <summary>
        /// Replace some section content by a section name
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="content">The content.</param>
        public void ReplaceSection(string sectionName, string content)
        {
            // Extraigo la sección que quiero reemplazar
            TemplateSection subSection = ExtractSection(sectionName);

            // Remuevo el content de la sección excepto el tag de inicio.
            _contentBuilder.Remove(subSection.FromContentIndex, subSection.ContentLength + subSection.EndTag.Length);

            // Reemplazo el tag de inicio por el content nuevo
            _contentBuilder.Replace(subSection.BeginTag, content);
        }

        /// <summary>
        /// Replace a section using the child reference
        /// </summary>
        /// <param name="section">The section.</param>
        /// <exception cref="NotDaughterSectionException">When the section to replace isn't child of the section</exception>
        public void ReplaceSection(TemplateSection section)
        {
            if (section._parent != this)
            {
                throw new NotDaughterSectionException(section.SectionName, SectionName);
            }

            if (section._isValidSection)
            {
                // Remuevo el content de la sección excepto el tag de inicio.
                _contentBuilder.Remove(section.FromContentIndex, section.ContentLength + section.EndTag.Length);

                // Reemplazo el tag de inicio por el content nuevo
                _contentBuilder.Replace(section.BeginTag, section.Content);
            }
        }

        /// <summary>
        /// Replace some tag with a list of sections
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="sectionList">The section list.</param>
        /// <param name="separator">The separator.</param>
        public void ReplaceSection(string sectionName, TemplateSectionCollection sectionList, string separator = "")
        {
            // Extraigo la sección que quiero reemplazar
            TemplateSection subSection = ExtractSection(sectionName);

            // Remuevo el content de la sección excepto el tag de inicio.
            _contentBuilder.Remove(subSection.FromContentIndex, subSection.ContentLength + subSection.EndTag.Length);

            // Reemplazo el tag de inicio por el content nuevo
            _contentBuilder.Replace(subSection.BeginTag, sectionList.GetAllContent(separator));
        }

        /// <summary>
        /// Remove all empty lines
        /// </summary>
        /// <remarks>
        /// Not recomended function
        /// </remarks>
        public void RemoveEmptyLines()
        {
            _contentBuilder = new StringBuilder(Regex.Replace(_contentBuilder.ToString(), "^\\s$[\\r\\n]*", string.Empty, RegexOptions.Multiline).Trim());
        }

        /// <summary>
        /// Remove all template tags (with their respective contents).
        /// </summary>
        /// <remarks>
        /// Only calls this methods after all replaces
        /// </remarks>
        public void RemoveInnerSections()
        {
            // Creo la clase para expresiones regulares, el tipo de patron depende del tipo de sección
            Regex regexPatternSection;
            switch (SectionType)
            {
                case TemplateType.ASPX: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericAspxSection, RegexOptions.IgnoreCase); break; }
                case TemplateType.HTML: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericHtmlSection, RegexOptions.IgnoreCase); break; }
                case TemplateType.CS: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericCsSection, RegexOptions.IgnoreCase); break; }
                case TemplateType.SQL: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericSqlSection, RegexOptions.IgnoreCase); break; }
                case TemplateType.CPP: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericCppSection, RegexOptions.IgnoreCase); break; }
                case TemplateType.PHP: { regexPatternSection = new Regex(RegularExpressionsPatterns.TemplateGenericPhpSection, RegexOptions.IgnoreCase); break; }
                default: { throw new NotSupportedTemplateTypeException(SectionType); }
            }

            // Busco todas las coincidencias del patron en el content de la sección
            MatchCollection matches = regexPatternSection.Matches(Content);

            // Inicializo una lista con las sectionList que contiene el content
            TemplateSectionCollection sectionList = new TemplateSectionCollection();

            foreach (Match match in matches)
            {
                // si es un tag de inicio
                if (match.Value.ToLower().Contains(TemplateTags.SectionBegin))
                {
                    string beginTag = match.Value;
                    string sectionName = string.Empty;
                    string variableName = string.Empty;

                    // reviso todos los grupos de la coincidencia, usualmente sería algo asi
                    // 0= <!-- o /*--
                    // 1= begin
                    // 2= section
                    // 3= NOMBRE_SECCION
                    // 4= as
                    // 5= NOMBRE_VARIABLE
                    // 6= --> o */
                    for (int i = 0; i < match.Groups.Count; i++)
                    {
                        Group group = match.Groups[i];

                        // recupero el nombre de la sección, el cual debe venir
                        // después del 'section'
                        if (group.Value.ToLower().Equals(TemplateTags.SectionTag))
                        {
                            sectionName = match.Groups[i + 1].Value;
                        }

                        // recupero el nombre de la variable, el cual debe venir
                        // despés del 'as'
                        else if (group.Value.ToLower().Equals(TemplateTags.SectionAlias))
                        {
                            variableName = match.Groups[i + 1].Value;
                            break;
                        }
                    }

                    // Se encontró una nueva sección, la guardo en la lista
                    TemplateSection seccion = new TemplateSection
                    {
                        BeginTag = beginTag,
                        SectionVariable = variableName,
                        SectionName = sectionName
                    };
                    sectionList.AddSection(seccion);

                }

                // o si es un tag de termino
                else if (match.Value.ToLower().Contains(TemplateTags.SectionEnd))
                {
                    string tagFin = match.Value;
                    string sectionName = string.Empty;

                    // reviso todos los grupos de la coincidencia, debería ser asi
                    // 0= <!-- o /*--
                    // 1= end
                    // 2= section
                    // 3= NOMBRE_SECCION
                    // 4= --> o */
                    for (int i = 0; i < match.Groups.Count; i++)
                    {
                        Group group = match.Groups[i];

                        // recupero el nombre de la sección, el cual debe venir
                        // después del 'section'
                        if (group.Value.ToLower().Equals(TemplateTags.SectionTag))
                        {
                            sectionName = match.Groups[i + 1].Value;
                            break;
                        }
                    }

                    // busco el tag de inicio el cual debería estar en la lista. El tag de inicio debería
                    // haberse ingresado en la lista antes de encontrar el de término. En el caso de que
                    // la encuentre, actualizo la entrada con los datos que faltan.
                    TemplateSection section = sectionList.FindSection(sectionName);

                    if (section != null)
                    {
                        section.EndTag = tagFin;
                    }
                    else
                    {
                        throw new InvalidFormatTagsException(sectionName);
                    }
                }
            }

            // Recorro todas las sectionList que encontré 
            foreach (TemplateSection section in sectionList.Sections)
            {
                string cleanText = _contentBuilder.ToString();

                // Verifico que los tags de inicio y término se encuentren en el Content. Esta verificación es para
                // las sectionList que estan contenidas dentro de otras las cuales son eliminadas recursivamente
                if (cleanText.Contains(section.BeginTag) && cleanText.Contains(section.EndTag))
                {
                    // Calculo los indices de inicio y término de los tags (los indices van cambiando a medida que limpio el content)
                    section.BeginTagIndex = cleanText.IndexOf(section.BeginTag, StringComparison.Ordinal);
                    section.EndTagIndex = cleanText.IndexOf(section.EndTag, section.BeginTagIndex, StringComparison.Ordinal);
                    section.FromContentIndex = section.BeginTagIndex + section.BeginTag.Length;

                    section.ContentLength = section.EndTagIndex - section.FromContentIndex;

                    // Remuevo la sección del content, desde el primer caracter del tag de inicio hasta el último caracter del tag de término
                    _contentBuilder.Remove(section.BeginTagIndex, section.BeginTag.Length + section.ContentLength + section.EndTag.Length);
                }
            }
        }

        /// <summary>
        /// Extrae una sección contenida dentro de esta sección de manera recursiva
        /// </summary>
        /// <param name="sectionName">Nombre de la Sección</param>
        /// <returns></returns>
        public TemplateSection ExtractSection(string sectionName)
        {
            // Creo la clase para expresiones regulares, el tipo de patron depende del tipo de sección (se hereda el tipo de la sección padre)
            Regex regexPatternSection;
            switch (SectionType)
            {
                case TemplateType.ASPX: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplateAspxSection, sectionName), RegexOptions.IgnoreCase); break; }
                case TemplateType.HTML: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplateHtmlSection, sectionName), RegexOptions.IgnoreCase); break; }
                case TemplateType.CS: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplateCsSection, sectionName), RegexOptions.IgnoreCase); break; }
                case TemplateType.SQL: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplateSqlSection, sectionName), RegexOptions.IgnoreCase); break; }
                case TemplateType.CPP: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplateCppSection, sectionName), RegexOptions.IgnoreCase); break; }
                case TemplateType.PHP: { regexPatternSection = new Regex(string.Format(RegularExpressionsPatterns.TemplatePhpSection, sectionName), RegexOptions.IgnoreCase); break; }
                default: { throw new NotSupportedTemplateTypeException(SectionType); }
            }

            // Busco todas las coincidencias del patron en el content de la sección
            MatchCollection matches = regexPatternSection.Matches(Content);

            int tagsNumber = 0;
            string beginTag = string.Empty;
            string endTag = string.Empty;
            string sectionVariable = string.Empty;

            // Recorro todas las coincidencias, las cuales sólo deberían ser dos (inicio y término)
            foreach (Match match in matches)
            {
                // si es un tag de inicio
                if (match.Value.ToLower().Contains(TemplateTags.SectionBegin))
                {
                    beginTag = match.Value;
                    tagsNumber += 1;

                    int i = 0;
                    // reviso todos los grupos de la coincidencia, usualmente sería algo asi
                    // 0= <!-- o /*--
                    // 1= begin
                    // 2= section
                    // 3= NOMBRE_SECCION
                    // 4= as
                    // 5= NOMBRE_VARIABLE
                    // 6= --> o */
                    foreach (Group group in match.Groups)
                    {
                        // recupero el nombre de la variable, el cual debe venir
                        // despés del 'as'
                        if (group.Value.ToLower().Equals(TemplateTags.SectionAlias))
                        {
                            sectionVariable = match.Groups[i + 1].Value;
                            break;
                        }
                        i += 1;
                    }
                }

                // o si es un tag de termino
                else if (match.Value.ToLower().Contains(TemplateTags.SectionEnd))
                {
                    endTag = match.Value;
                    tagsNumber += 1;
                }
            }

            // Verifico que hayan sido dos sectionList las que encontré
            if (tagsNumber != 2)
            {
                throw new SectionNotFoundException(SectionName, sectionName);
            }

            // IndexOf retorna la ubicación del primer caracter respecto al Content
            int beginTagIndex = Content.IndexOf(beginTag, StringComparison.Ordinal);
            int endTagIndex = Content.IndexOf(endTag, 0, StringComparison.Ordinal);

            // Verifico que el tag de inicio sea predecesor del tag de término
            if (beginTagIndex > endTagIndex)
            {
                throw new InvalidFormatTagsException(sectionName);
            }

            int fromContentIndex = beginTagIndex + beginTag.Length;
            int daughterContentLength = endTagIndex - fromContentIndex;

            // Creo la nueva sección y le asigno todas las variables calculadas
            TemplateSection seccion = new TemplateSection
            {
                _parent = this,
                _contentBuilder = new StringBuilder(Content, fromContentIndex, daughterContentLength, Content.Length),
                SectionName = sectionName,
                SectionType = SectionType,
                SectionVariable = sectionVariable,
                BeginTag = beginTag,
                EndTag = endTag,
                BeginTagIndex = beginTagIndex,
                EndTagIndex = endTagIndex,
                FromContentIndex = fromContentIndex,
                ContentLength = daughterContentLength,
                _isValidSection = true
            };
            return seccion;
        }

        private string GetReplaceTag(string tagName, bool isLocalVariable)
        {
            // Asigno el nombre de la etiqueta, si es variable local, es del tipo {VARIABLE.ETIQUETA}, si no, es del tipo {ETIQUETA} simplemente
            return isLocalVariable ? string.Format(TemplateTags.SectionLocalVariable, SectionVariable, tagName) : string.Format(TemplateTags.SectionGlobalVariable, tagName);
        }
    }
}
