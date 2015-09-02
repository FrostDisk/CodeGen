using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Controls
{
    public interface ITemplateParameter
    {
        string ParameterName { get; set; }

        string ParameterCode { get; set; }

        string ParameterValue { get; set; }

        bool IsUpdated { get; set; }

        bool IsDefaultValue { get; }

        Type Type { get; }

        void UpdateValue(string value);

        bool ValidateForm();

        void RestoreValue();
    }
}
