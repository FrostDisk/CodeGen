using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.App.Controls
{
    interface IBaseForm
    {
        void LoadLocalVariables();

        bool ValidateForm();
    }
}
