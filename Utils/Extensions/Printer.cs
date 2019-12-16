using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Extensions
{
    public static class Printer
    {
        public static IList<T> Print<T>(this IList<T> array)
        {
            for (int i = 0; i < array.Count; i++)
                if (i != array.Count - 1)
                    Console.Write($"{array[i]}, ");
                else
                    Console.WriteLine(array[i]);

            return array;
        }
    }
}
