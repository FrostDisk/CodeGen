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
        internal static readonly string TemplateGenericAspxSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        internal static readonly string TemplateGenericHtmlSection = string.Format("(<!--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(-->)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        internal static readonly string TemplateGenericCsSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        internal static readonly string TemplateGenericSqlSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        internal static readonly string TemplateGenericCppSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
        internal static readonly string TemplateGenericPhpSection = string.Format("(/\\*--){0}*({1}|{2}){0}+({3}){0}+({4}){0}+(({5}){0}+({4}))?{0}*(\\*/)", WhiteSpace, TemplateTags.SectionBegin, TemplateTags.SectionEnd, TemplateTags.SectionTag, ValidVariableName, TemplateTags.SectionAlias);
    }
}
