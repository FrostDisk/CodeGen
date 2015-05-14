using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Domain
{
    [Serializable]
    public class ProjectPluginProperties : ProjectPlugin
    {
        public List<PluginParameter> Parameters { get; set; }
    }
}
