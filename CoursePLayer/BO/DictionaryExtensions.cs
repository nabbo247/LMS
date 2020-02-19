using System;
using System.Collections.Generic;
using System.Linq;

namespace HRS.CoursePlayer
{
    public static class DictionaryExtensions
    {
        public static List<TValue> SortedValues<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) where TValue : IComparable<TValue>
        {
            var list = dictionary.Values.ToList();
            list.Sort();
            return list;
        }
    }
}
