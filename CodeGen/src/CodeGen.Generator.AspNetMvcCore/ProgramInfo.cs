using System;
using System.IO;
using System.Reflection;

namespace CodeGen.Generator.AspNetMvcCore
{
    internal static class ProgramInfo
    {
        private static Assembly _currentAssembly;

        private static Assembly CurrentAssembly
        {
            get { return _currentAssembly ?? (_currentAssembly = Assembly.GetExecutingAssembly()); }
        }

        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = CurrentAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (!string.IsNullOrWhiteSpace(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(CurrentAssembly.CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                var version = CurrentAssembly.GetName().Version.ToString();
                if (version.EndsWith(".0.0"))
                {
                    return version.Substring(0, version.LastIndexOf(".0.0", StringComparison.Ordinal));
                }
                if (version.EndsWith(".0"))
                {
                    return version.Substring(0, version.LastIndexOf(".0", StringComparison.Ordinal));
                }

                return version;
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = CurrentAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = CurrentAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = CurrentAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = CurrentAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }
}
