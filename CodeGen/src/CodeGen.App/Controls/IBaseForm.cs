namespace CodeGen.Controls
{
    /// <summary>
    /// IBaseForm
    /// </summary>
    public interface IBaseForm
    {
        /// <summary>
        /// Loads the local variables.
        /// </summary>
        void LoadLocalVariables();

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        bool ValidateForm();
    }
}
