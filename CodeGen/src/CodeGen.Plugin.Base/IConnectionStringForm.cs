namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IConnectionStringForm
    /// </summary>
    public interface IConnectionStringForm
    {
        /// <summary>
        /// LoadLocalVariables
        /// </summary>
        void LoadLocalVariables();

        /// <summary>
        /// GetConnectionString
        /// </summary>
        /// <returns></returns>
        string GetConnectionString();

        /// <summary>
        /// ValidateForm
        /// </summary>
        /// <returns></returns>
        bool ValidateForm();
    }
}
