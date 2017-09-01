using System;

namespace CodeGen.Plugin.Base.Controls
{
    /// <summary>
    /// ITemplateParameter
    /// </summary>
    public interface ITemplateParameter
    {
        /// <summary>
        /// ParameterName
        /// </summary>
        string ParameterName { get; set; }

        /// <summary>
        /// ParameterCode
        /// </summary>
        string ParameterCode { get; set; }

        /// <summary>
        /// ParameterValue
        /// </summary>
        string ParameterValue { get; set; }

        /// <summary>
        /// IsUpdated
        /// </summary>
        bool IsUpdated { get; set; }

        /// <summary>
        /// IsDefaultValue
        /// </summary>
        bool IsDefaultValue { get; }

        /// <summary>
        /// Type
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Updates the value.
        /// </summary>
        /// <param name="value">The value.</param>
        void UpdateValue(string value);

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        bool ValidateForm();

        /// <summary>
        /// Restores the value.
        /// </summary>
        void RestoreValue();
    }
}
