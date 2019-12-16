using System;
using System.Collections.Generic;
using Utils.Extensions;

namespace Application.Sorts
{
    public static class Quick
    {

        public static IList<T> QuickSort<T>(this IList<T> array, Func<T, T, bool> comparingFunction)
        {
            return Sort(array, 0, array.Count - 1, comparingFunction);
        }

        public static IList<int> QuickSort(this IList<int> array)
        {
            return array.QuickSort<int>((a, b) => (a < b));
        }

        private static IList<T> Sort<T>(IList<T> array, int inicio, int fim, Func<T, T, bool> comparingFunction)
        {
            if (inicio < fim)
            {
                int pivot = ChoosePivot(array, inicio, fim);

                array.Swap(pivot, fim);

                int x = Partition(array, inicio, fim, comparingFunction);

                Sort(array, inicio, x - 1, comparingFunction);
                Sort(array, x + 1, fim, comparingFunction);
            }

            return array;
        }

        public static int Partition<T>(IList<T> array, int inicio, int fim, Func<T, T, bool> comparingFunction)
        {
            T pivot = array[fim];
            int i = inicio;

            for (int j = inicio; j < fim - 1; j++)
            {
                if (comparingFunction(array[j], pivot))
                {
                    array.Swap(i, j);
                    i++;
                }
            }

            array.Swap(i, fim);
            return i;
        }

        private static int ChoosePivot<T>(IList<T> array, int inicio, int fim) => fim;  
    }
}
