using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CodeGen.Library.Security
{
    /// <summary>
    /// StringEncryptorHelper
    /// </summary>
    public static class StringEncryptorHelper
    {
        private static readonly byte[] _salt = new byte[] { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c };

        /// <summary>
        /// Encrypts a string using a privateKey
        /// </summary>
        /// <param name="nonEncryptedString">Cadena de caracteres</param>
        /// <param name="privateKey">Contraseña</param>
        /// <returns>Cadena de texto encriptada</returns>
        public static string Encrypt(string nonEncryptedString, string privateKey)
        {
            return !string.IsNullOrWhiteSpace(nonEncryptedString) ? Encrypt(Encoding.UTF8.GetBytes(nonEncryptedString), privateKey) : string.Empty;
        }

        /// <summary>
        /// Encrypts a bytes array using a privateKey
        /// </summary>
        /// <param name="nonEncryptedBytes">Arreglo de bytes</param>
        /// <param name="privateKey">Contraseña</param>
        /// <returns>Cadena de texto encriptada</returns>
        public static string Encrypt(byte[] nonEncryptedBytes, string privateKey)
        {
            if (string.IsNullOrWhiteSpace(privateKey))
            {
                throw new ArgumentNullException("password", "The PrivateKey cannot be empty");
            }
            Rijndael rijndael = Rijndael.Create();
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(privateKey, _salt);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(nonEncryptedBytes, 0, nonEncryptedBytes.Length);
            cryptoStream.Close();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        /// <summary>
        /// Decrypt a string using a privateKey
        /// </summary>
        /// <param name="encryptedString">Cadena encriptada</param>
        /// <param name="privateKey">Contraseña</param>
        /// <returns>Cadena de texto original desencriptada</returns>
        public static string Decrypt(string encryptedString, string privateKey)
        {
            return !string.IsNullOrWhiteSpace(encryptedString) ? Decrypt(Convert.FromBase64String(encryptedString), privateKey) : string.Empty;
        }

        /// <summary>
        /// Decrypt a bytes array using a privateKey
        /// </summary>
        /// <param name="cipher">Arreglo de bytes encriptado</param>
        /// <param name="privateKey">Contraseña</param>
        /// <returns>Cadena de texto original desencriptada</returns>
        public static string Decrypt(byte[] cipher, string privateKey)
        {
            if (string.IsNullOrWhiteSpace(privateKey))
            {
                throw new ArgumentNullException("password", "The PrivateKey cannot be empty");
            }
            Rijndael rijndael = Rijndael.Create();
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(privateKey, _salt);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cipher, 0, cipher.Length);
            cryptoStream.Close();
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}
