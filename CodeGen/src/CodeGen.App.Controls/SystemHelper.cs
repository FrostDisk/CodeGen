using CodeGen.App.Controls.Classes;
using CodeGen.App.Controls.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen.App.Controls
{
    public static class SystemHelper
    {
        [DllImport("kernel32", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string lpFileName);

        internal static bool CheckLibrary(string fileName)
        {
            return LoadLibrary(fileName) != IntPtr.Zero;
        }

        private static SupportedTypes _loadedSupportedTypes;

        internal static SupportedTypes GetSupportedTypes()
        {
            if (_loadedSupportedTypes != null)
            {
                return _loadedSupportedTypes;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(SupportedTypes));

            using (TextReader reader = new StringReader(Resources.SupportedTypes))
            {
                _loadedSupportedTypes = serializer.Deserialize(reader) as SupportedTypes;
            }

            _loadedSupportedTypes.DatabaseTypes.RemoveAll(item => !string.IsNullOrWhiteSpace(item.Library) && !CheckLibrary(item.Library));
            _loadedSupportedTypes.Languages.RemoveAll(item => !string.IsNullOrWhiteSpace(item.Library) && !CheckLibrary(item.Library));

            return _loadedSupportedTypes;
        }
    }
}
