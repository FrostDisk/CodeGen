﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.App.Controls
{
    interface IBaseUserControl : IBaseForm
    {
        bool IsLoaded { get; set; }
    }
}
