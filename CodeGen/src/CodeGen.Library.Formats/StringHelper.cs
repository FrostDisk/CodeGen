using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// StringHelper
    /// </summary>
    public static class StringHelper
    {
        private const string ClassNumberPrefix = "_";
        private const string StartWithNumber = "^[0-9]";
        private const string SpecialCharacters = "\\W+";

        /// <summary>
        /// AreEquals
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="ignoreWhiteSpaces"></param>
        /// <returns></returns>
        public static bool AreEquals(string source, string target, bool ignoreWhiteSpaces = false)
        {
            bool isNullSource = string.IsNullOrWhiteSpace(source);
            bool isNullTarget = string.IsNullOrWhiteSpace(target);

            if (isNullSource && isNullTarget)
            {
                return true;
            }

            if (isNullSource ^ isNullTarget)
            {
                return false;
            }

            if (ignoreWhiteSpaces)
            {
                string fixedStringOne = Regex.Replace(source, @"\s+", string.Empty);
                string fixedStringTwo = Regex.Replace(target, @"\s+", string.Empty);

                return string.Equals(fixedStringOne, fixedStringTwo, StringComparison.OrdinalIgnoreCase);
            }
            return source.SequenceEqual(target);
        }

        /// <summary>
        /// Compare
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Compare(string source, string target)
        {
            bool isNullSource = string.IsNullOrWhiteSpace(source);
            bool isNullTarget = string.IsNullOrWhiteSpace(target);

            if (isNullSource && !isNullTarget)
            {
                return -target.Length;
            }
            if (!isNullSource && isNullTarget)
            {
                return source.Length;
            }

            return string.CompareOrdinal(source, target);
        }

        /// <summary>
        /// ConvertToNumbersList
        /// </summary>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static List<int> ConvertToNumbersList(string text, char separator = ',')
        {
            string[] elements = text.Split(separator);
            List<int> numberList = new List<int>();
            foreach (string elem in elements.Where(s => !string.IsNullOrWhiteSpace(s)))
            {
                int nro;
                if (int.TryParse(elem.Trim(), out nro))
                {
                    numberList.Add(nro);
                }
            }
            return numberList;
        }

        /// <summary>
        /// CreateUniqueFileName
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="maxLength"></param>
        /// <param name="preffix"></param>
        /// <returns></returns>
        public static string CreateUniqueFileName(string fileName, int maxLength = 0, string preffix = "")
        {
            string baseName = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName.ToLower());

            string uniqueId = Guid.NewGuid().ToString();
            uniqueId = uniqueId.Substring(0, uniqueId.IndexOf("-", StringComparison.Ordinal)).Replace("-", string.Empty);
            int nameLength = maxLength > 0 ? maxLength - preffix.Length - uniqueId.Length - 1 : 0;
            if (nameLength < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("maxLength no puede ser menor a {0}", preffix.Length + uniqueId.Length));
            }

            string titleFormatName = ConvertToSafeCodeName(baseName, false);
            return string.Format("{0}{1}_{2}{3}", preffix, nameLength > 0 && titleFormatName.Length > nameLength ? titleFormatName.Substring(0, nameLength) : titleFormatName, uniqueId, extension);
        }

        /// <summary>
        /// CreateUniqueName
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="maxLength"></param>
        /// <param name="preffix"></param>
        /// <returns></returns>
        public static string CreateUniqueName(string baseName, int maxLength = 0, string preffix = "")
        {
            string uniqueId = Guid.NewGuid().ToString();
            uniqueId = uniqueId.Substring(0, uniqueId.IndexOf("-", StringComparison.Ordinal)).Replace("-", string.Empty);
            int nameLength = maxLength > 0 ? maxLength - preffix.Length - uniqueId.Length - 1 : 0;
            if (nameLength < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("maxLength no puede ser menor a {0}", preffix.Length + uniqueId.Length));
            }

            string titleFormatName = ConvertToSafeCodeName(baseName, string.IsNullOrWhiteSpace(preffix));
            return string.Format("{0}{1}_{2}", preffix, nameLength > 0 && titleFormatName.Length > nameLength ? titleFormatName.Substring(0, nameLength) : titleFormatName, uniqueId);
        }

        /// <summary>
        /// RemovePrefix
        /// </summary>
        /// <param name="text"></param>
        /// <param name="prefixSeparator"></param>
        /// <returns></returns>
        public static string RemovePrefix(string text, string prefixSeparator = "_")
        {
            return text.Contains(prefixSeparator) ? text.Substring(text.IndexOf(prefixSeparator, StringComparison.Ordinal) + 1) : text;
        }

        /// <summary>
        /// ConvertToSafeCodeName
        /// </summary>
        /// <param name="text"></param>
        /// <param name="checkIfStartWithNumber"></param>
        /// <returns></returns>
        public static string ConvertToSafeCodeName(string text, bool checkIfStartWithNumber = true)
        {
            return (checkIfStartWithNumber && (new Regex(StartWithNumber)).IsMatch(text) ? ClassNumberPrefix : string.Empty) + CleanSpecialCharacters(text).Replace(" ", "_");
        }

        /// <summary>
        /// ConvertToSafeFileName
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ConvertToSafeFileName(string text)
        {
            Path.GetInvalidFileNameChars().ToList().ForEach(t => text = text.Replace(new string(t, 1), string.Empty));

            return text;
        }

        /// <summary>
        /// ConvertToSafeConstantName
        /// </summary>
        /// <param name="text"></param>
        /// <param name="checkIfStartWithNumber"></param>
        /// <returns></returns>
        public static string ConvertToSafeConstantName(string text, bool checkIfStartWithNumber = true)
        {
            return ConvertToTitleCase(ConvertToSafeCodeName(text, checkIfStartWithNumber));
        }

        /// <summary>
        /// ConverToInstanceName
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ConverToInstanceName(string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? text.ToUpper().StartsWith("ID") ? "id" + text.Substring(2) : char.ToLower(text[0]) + text.Substring(1) : string.Empty;
        }

        /// <summary>
        /// ConvertToTitleCase
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ConvertToTitleCase(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        /// <summary>
        /// CleanSpecialCharacters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CleanSpecialCharacters(string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? Regex.Replace(RemoveDiacritics(text), SpecialCharacters, " ", RegexOptions.Compiled) : string.Empty;
        }

        /// <summary>
        /// RemoveDiacritics
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveDiacritics(string text)
        {
            string stFormD = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char t in from t in stFormD let uc = CharUnicodeInfo.GetUnicodeCategory(t) where uc != UnicodeCategory.NonSpacingMark select t)
            {
                sb.Append(t);
            }

            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        /// <summary>
        /// Pluralize
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string Pluralize(string word)
        {
            PluralizationService service = PluralizationService.CreateService(CultureInfo.CreateSpecificCulture("en-US"));

            return service.IsPlural(word) ? word : service.Pluralize(word);
        }

        /// <summary>
        /// Singularize
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string Singularize(string word)
        {
            PluralizationService service = PluralizationService.CreateService(CultureInfo.CreateSpecificCulture("en-US"));

            return service.IsSingular(word) ? word : service.Singularize(word);
        }
    }
}
