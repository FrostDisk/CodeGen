using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Generator.Default.Controls
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
