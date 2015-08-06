using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Library.Security
{
    /// <summary>
    /// QueryStringEncryptorHelper
    /// </summary>
    public static class QueryStringEncryptorHelper
    {
        private static readonly byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xab, 0xcd, 0xef };

        /// <summary>
        /// Decrypts the following string encrypted using the private key specified
        /// </summary>
        /// <param name="encryptedBytes">Encrypted Bytes.</param>
        /// <param name="privateKey">Private Key</param>
        /// <returns>Cadena desencriptada</returns>
        public static string Decrypt(byte[] encryptedBytes, string privateKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(privateKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = encryptedBytes;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

        /// <summary>
        /// Decrypts the following string encrypted using the private key specified
        /// </summary>
        /// <param name="encryptedBytes">Encrypted Bytes.</param>
        /// <param name="privateKey">Private Key</param>
        /// <returns>Cadena desencriptada</returns>
        public static string Decrypt(string encryptedString, string privateKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(privateKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Base64EncryptorHelper.Base64Decode(encryptedString);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

        /// <summary>
        /// Encrypts the following string using the private key specified
        /// </summary>
        /// <param name="bytes">Bytes array</param>
        /// <param name="privateKey">Private Key</param>
        /// <returns>Encrypted String</returns>
        public static string Encrypt(byte[] bytes, string privateKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(privateKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = bytes;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Base64EncryptorHelper.Base64Encode(ms.ToArray());
        }

        /// <summary>
        /// Encrypts the following string using the private key specified
        /// </summary>
        /// <param name="nonEncryptedString">Non Encrypted String</param>
        /// <param name="privateKey">Private Key</param>
        /// <returns>Encrypted String</returns>
        public static string Encrypt(string nonEncryptedString, string privateKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(privateKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(nonEncryptedString);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Base64EncryptorHelper.Base64Encode(ms.ToArray());
        }

        /// <summary>
        /// Encrypts the following string using the private key specified
        /// </summary>
        /// <param name="nonEncryptedString">Non Encrypted String</param>
        /// <param name="privateKey">Private Key</param>
        /// <returns>Encrypted Bytes Array</returns>
        public static byte[] EncryptToBytes(string nonEncryptedString, string privateKey)
        {
            byte[] key = Encoding.UTF8.GetBytes(privateKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(nonEncryptedString);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return ms.ToArray();
        }
    }
}
