using System.Collections.Generic;

namespace CodeGen.Core
{
    internal static class DefaultFilters
    {
        public static Dictionary<string, string> Filters = new Dictionary<string, string>()
        {
            {".cpp", "C++ source file (*.cpp)|*.cpp"},
            {".cs", "C# source file (*.cs)|*.cs"},
            {".cshtml", "ASP.NET Razor Web Page (*.cshtml)|*.cshtml" },
            {".hpp", "C++ header file (*.hpp)|*.hpp"},
            {".java", "Java source file (*.java)|*.java"},
            {".php", "PHP Hypertext Preprocessor file (*.php)|*.php"},
            {".py", "Python file (*.py)|*.py"},
            {".sql", "Structured Query Language file (*.sql)|*.sql"},
            {".txt", "Normal text file (*.txt)|*.txt"},
            {".vb", "Visual Basic file (*.vb)|*.vb"},
            {".vbhtml", "ASP.NET Razor Web Page (*.vbhtml)|*.vbhtml" },
            {".xml", "eXtensible Markup Language file (*.xml)|*.xml"},
        };

        //public string this[string key]
        //{
        //    get { return this.FirstOrDefault(t => t.Key == key); }
        //}
    }
}
