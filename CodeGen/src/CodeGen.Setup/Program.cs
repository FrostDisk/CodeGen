using System;
using WixSharp;

namespace WixSharpSetup
{
    class Program
    {
        static void Main()
        {
            const string name = "CodeGen";
            const string company = "FrostDisk Chile";

            var project = new Project()
            {
                Name = name,
                GUID = new Guid("a48c5724-e8b9-4caf-a231-00f15057d15c"),
                Dirs = new[]
                    {
                        new Dir(@"%ProgramFiles%\" + company + @"\" + name)
                        {
                            Files = new []
                            {
                                new File(@"CodeGen.exe"),
                                new File(@"CodeGen.exe.config"),
                                new File(@"license.txt"),
                                new File(@"CodeGen.Data.dll"),
                                new File(@"CodeGen.Domain.dll"),
                                new File(@"CodeGen.Library.AccessModel.dll"),
                                new File(@"CodeGen.Library.Formats.dll"),
                                new File(@"CodeGen.Library.Security.dll"),
                                new File(@"CodeGen.Library.System.dll"),
                                new File(@"CodeGen.Plugin.Base.dll")
                            }
                        }
                    }
            };

            Compiler.BuildMsi(project);
        }
    }
}
