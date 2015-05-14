using CodeGen.Domain;

namespace CodeGen.Controls
{
    public interface IGeneratorUserControl : IBaseUserControl
    {
        Project Project { get; set; }
    }
}
