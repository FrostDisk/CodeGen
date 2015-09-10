namespace CodeGen.Plugin.Base
{
    public interface IAssemblyDetails
    {
        string Title { get; }

        string Version { get; }

        string Description { get; }

        string Author { get; }

        string Url { get; }
    }
}
