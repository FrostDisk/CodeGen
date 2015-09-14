namespace CodeGen.Plugin.Base
{
    public interface IConnectionStringForm
    {
        void LoadLocalVariables();

        string GetConnectionString();

        bool ValidateForm();
    }
}
