using System.Web;

namespace freaxnx01.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }
        
        public static string AsNullIfEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str) ? str : null;
        }
        
        public static string UrlEncode(this string text)
        {
            return HttpUtility.UrlEncode(text);
        }

        public static string PutInQuotes(this string text)
        {
            return PutIn(text, '\'');
        }

        public static string PutInDoubleQuotes(this string text)
        {
            return PutIn(text, '"');
        }

        public static string PutInRoundBrackets(this string text)
        {
            return PutIn(text, '(', ')');
        }

        public static string PutInSquareBrackets(this string text)
        {
            return PutIn(text, '[', ']');
        }

        public static string PutInCurlyBrackets(this string text)
        {
            return PutIn(text, '{', '}');
        }

        public static string PutIn(this string text, char startChar, char endChar = char.MinValue)
        {
            if (endChar == char.MinValue)
            {
                endChar = startChar;
            }

            return $"{startChar}{text}{endChar}";
        }
    }
}