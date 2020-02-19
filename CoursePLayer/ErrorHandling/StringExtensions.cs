using System;
using System.Text.RegularExpressions;

namespace HRS.CoursePlayer
{
    public static class StringExtensions
    {
        private static Regex LeadingZeros = new Regex("^0+\\d+$", RegexOptions.Compiled);

        public static string ToExcelTextCell(this string item)
        {
            if (LeadingZeros.IsMatch(item))
            {
                return string.Format("=\"{0}\"", item);
            }

            return item;
        }

        public static string AppendUrlParameter(this string url, string name, string value)
        {
            return String.Format("{0}{1}{2}={3}", url, (url.Contains("?") ? "&" : "?"), name, value);
        }
    }
}
