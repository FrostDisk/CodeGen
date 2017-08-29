using System.Text.RegularExpressions;

namespace CodeGen.Library.Formats
{
    internal class RegularExpressionsPatterns
    {
        internal static readonly string WhiteSpace = "[\\s\\t\\n\\r]";
        internal static readonly string SpecialCharacters = "\\W+";
        internal static readonly string StartWithNumber = "^[0-9]";
        internal static readonly string ValidVariableName = "[a-zA-Z_]?[a-zA-Z0-9_]*";

        internal static readonly string TemplateAspxSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);
        internal static readonly string TemplateHtmlSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);
        internal static readonly string TemplateCsSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);
        internal static readonly string TemplateSqlSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);
        internal static readonly string TemplateCppSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);
        internal static readonly string TemplatePhpSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({{0}}){0}+(({4}){0}+({5}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, TemplateTags.SectionAlias, ValidVariableName);

        private static readonly string _templateGenericAspxSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        private static readonly string _templateGenericHtmlSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        private static readonly string _templateGenericCsSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        private static readonly string _templateGenericSqlSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        private static readonly string _templateGenericCppSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        private static readonly string _templateGenericPhpSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);

        internal static readonly Regex RegexTemplateGenericAspxSection = new Regex(_templateGenericAspxSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        internal static readonly Regex RegexTemplateGenericHtmlSection = new Regex(_templateGenericHtmlSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        internal static readonly Regex RegexTemplateGenericCsSection = new Regex(_templateGenericCsSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        internal static readonly Regex RegexTemplateGenericSqlSection = new Regex(_templateGenericSqlSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        internal static readonly Regex RegexTemplateGenericCppSection = new Regex(_templateGenericCppSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        internal static readonly Regex RegexTemplateGenericPhpSection = new Regex(_templateGenericPhpSection, RegexOptions.Compiled | RegexOptions.IgnoreCase);

    }
}
