using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo
{
    public static class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];

                int j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }

        public static void Sort<T>(IList<T> array, Func<T, T, bool> comparingFunction)
        {
            for (int i = 1; i < array.Count; i++)
            {
                T current = array[i];

                int j = i - 1;
                while (j >= 0 && comparingFunction(array[j], current))
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }
        }
    }
}
