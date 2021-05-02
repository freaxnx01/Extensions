using System;
using System.Collections.Generic;

namespace freaxnx01.Extensions
{
    public static class DictionaryExtension
    {
        public static void AddRange<T, S>(this Dictionary<T, S> source, 
            Dictionary<T, S> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Empty collection");
            }

            foreach (var item in collection)
            {
                if(!source.ContainsKey(item.Key)){
                    source.Add(item.Key, item.Value);
                }
            }
        }        

    }
}