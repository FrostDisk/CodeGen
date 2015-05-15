using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.System.IO
{
    public static class FolderHelper
    {
        /// <summary>
        /// Determines whether [is directory empty] [the specified path].
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static bool IsDirectoryEmpty(string path)
        {
            IEnumerable<string> items = Directory.EnumerateFileSystemEntries(path);
            using (IEnumerator<string> en = items.GetEnumerator())
            {
                return !en.MoveNext();
            }
        }
    }
}
