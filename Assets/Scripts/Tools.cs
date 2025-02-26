using System;
using System.Collections.Generic;

namespace Tools
{

    public static class StrExtensions
    {
        public static string ToUpperFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            char[] a = str.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static string ToLowerFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            char[] a = str.ToCharArray();
            a[0] = char.ToLower(a[0]);
            return new string(a);
        }

        public static bool Contains(this string source, string value, StringComparison comp)
        {
            return source?.IndexOf(value, comp) >= 0;
        }

        public static int ToInt(this string str)
        {
            int y = 0;
            int.TryParse(str, out y);
            return y;
        }
    }

    public static class DicExtensions
    {
        public static int RemoveAll<T, T2>(this Dictionary<T, T2> dictionary, IEnumerable<T> keys)
        {
            int count = 0;

            foreach (var key in keys)
                if (dictionary.Remove(key))
                    count++;

            return count;
        }
    }

    public static class ListExtensions
    {
        public static int RemoveAll<T>(this List<T> list, IEnumerable<T> keys)
        {
            int count = 0;

            foreach (var key in keys)
                if (list.Remove(key))
                    count++;

            return count;
        }
    }

    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }
}