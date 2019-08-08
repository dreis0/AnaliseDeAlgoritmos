using System;
using System.Collections.Generic;

namespace AnaliseDeAlgoritmo
{
    public static class Insertion
    {
        public static IList<int> InsertionSort(this IList<int> array)
        {
            return array.InsertionSort((a, b) => a < b);
        }

        public static IList<T> InsertionSort<T>(this IList<T> array, Func<T, T, bool> comparingFunction)
        {
            for (int i = 1; i < array.Count; i++)
            {
                T current = array[i];

                int j = i - 1;
                while (j >= 0 && comparingFunction(current, array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }

            return array;
        }
    }
}
