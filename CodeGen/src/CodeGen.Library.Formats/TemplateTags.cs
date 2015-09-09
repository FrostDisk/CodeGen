namespace CodeGen.Library.Formats
{
    internal class TemplateTags
    {
        internal static readonly string SectionBegin = "begin";
        internal static readonly string SectionEnd = "end";
        internal static readonly string SectionTag = "section";
        internal static readonly string SectionAlias = "as";
        internal static readonly string SectionLocalVariable = "{{{0}.{1}}}";
        internal static readonly string SectionGlobalVariable = "{{{0}}}";
    }
}
