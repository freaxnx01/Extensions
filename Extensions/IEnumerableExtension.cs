using System.Collections.Generic;

namespace freaxnx01.Extensions
{
    public static class IEnumerableExtension
    {
        // Source: https://stackoverflow.com/questions/24390005/checking-for-empty-or-null-liststring
        public static IEnumerable<T> Safe<T>(this IEnumerable<T> source)
        {
            
            if (source == null)
            {
                yield break;
            }

            foreach (var item in source)
            {
                yield return item;
            }
        }
    }
}