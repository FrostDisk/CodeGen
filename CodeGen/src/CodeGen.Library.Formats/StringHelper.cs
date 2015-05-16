using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGen.Library.Formats
{
    public static class StringHelper
    {
        private const string ClassNumberPrefix = "_";
        private const string StartWithNumber = "^[0-9]";
        private const string SpecialCharacters = "\\W+";

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

        public static string ConvertToSafeCodeName(string text, bool checkIfStartWithNumber = true)
        {
            return (checkIfStartWithNumber && (new Regex(StartWithNumber)).IsMatch(text) ? "_" : string.Empty) + CleanSpecialCharacters(text).Replace(" ", "_");
        }

        public static string ConvertToTitleCase(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static string ConvertToSafeVariableName(string text)
        {
            Regex regex = new Regex(StartWithNumber);
            Match match = regex.Match(text);

            return CleanSpecialCharacters(CultureInfo.CurrentCulture.TextInfo.ToUpper(match.Success ? string.Format("{0}{1}", ClassNumberPrefix, text.Trim()) : text.Trim())).Replace(" ", "_");
        }

        public static string CleanSpecialCharacters(string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? Regex.Replace(RemoveDiacritics(text), SpecialCharacters, " ", RegexOptions.Compiled) : string.Empty;
        }

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
    }
}
