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
    }
}