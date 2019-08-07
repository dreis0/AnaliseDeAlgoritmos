using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo
{
    public static class Utils
    {
        public static void Print<T>(this IList<T> array)
        {
            for (int i = 0; i < array.Count; i++)
                if (i != array.Count - 1)
                    Console.Write($"{array[i]}, ");
                else
                    Console.WriteLine(array[i]);
        }
    }
}
