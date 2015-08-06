using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.Security
{
    /// <summary>
    /// Base64EncryptorHelper
    /// </summary>
    public static class Base64EncryptorHelper
    {
        /// <summary>
        /// The method create a Base64 encoded string from a normal string.
        /// </summary>
        /// <param name="toEncode">The String containing the characters to encode.</param>
        /// <returns>The Base64 encoded string.</returns>
        public static string Base64Encode(string toEncode)
        {
            return !string.IsNullOrWhiteSpace(toEncode) ? Base64Encode(Encoding.UTF8.GetBytes(toEncode)) : string.Empty;
        }

        /// <summary>
        /// The method create a Base64 encoded string from a normal string.
        /// </summary>
        /// <param name="toEncode">The String containing the characters to encode.</param>
        /// <returns>The Base64 encoded string.</returns>
        public static string Base64Encode(byte[] toEncode)
        {
            return Convert.ToBase64String(toEncode);
        }

        /// <summary>
        /// The method to Decode your Base64 strings.
        /// </summary>
        /// <param name="encodedData">The String containing the characters to decode.</param>
        /// <returns>A String containing the results of decoding the specified sequence of bytes.</returns>
        public static byte[] Base64Decode(string encodedData)
        {
            return Convert.FromBase64String(encodedData);
        }

        /// <summary>
        /// The method to Decode your Base64 strings.
        /// </summary>
        /// <param name="encodedData">The String containing the characters to decode.</param>
        /// <returns>A String containing the results of decoding the specified sequence of bytes.</returns>
        public static string Base64DecodeToString(string encodedData)
        {
            return !string.IsNullOrWhiteSpace(encodedData) ? Encoding.UTF8.GetString(Base64Decode(encodedData)) : string.Empty;
        }
    }
}
