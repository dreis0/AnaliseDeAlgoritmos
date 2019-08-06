using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo.Sorts
{
    public static class MergeSort
    {
        public static void Sort<T>(IList<T> array, Func<T, T, bool> comparingFunction)
        {
            SortAndMerge<T>(array, 0, array.Count, comparingFunction);
        }

        private static void SortAndMerge<T>(IList<T> array, int start, int end, Func<T, T, bool> comparingFunction)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;

                SortAndMerge<T>(array, start, middle, comparingFunction);
                SortAndMerge<T>(array, middle + 1, end, comparingFunction);

                Merge<T>(array, start, middle, end, comparingFunction);
            }
        }

        public static void Merge<T>(IList<T> array, int start, int middle, int end, Func<T, T, bool> comparingFunction)
        {
            int sizeL = middle - start + 1;
            int sizeR = end - middle;

            T[] L = new T[sizeL];
            T[] R = new T[sizeR];

            for (int h = 0; h < sizeL; h++)
                L[h] = array[start + h];
            for (int h = 0; h < sizeR; h++)
                R[h] = array[middle + h + 1];

            int i = 0, j = 0, k = start;

            while (i < sizeL && j < sizeR)
            {
                if(comparingFunction(L[i], R[j]))
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < sizeL)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < sizeR)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        public static void Sort(int[] array)
        {
            SortAndMerge(array, 0, array.Length - 1);
        }

        private static void SortAndMerge(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;

                SortAndMerge(array, start, middle);
                SortAndMerge(array, middle + 1, end);

                Merge(array, start, middle, end);
            }
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int sizeL = middle - start + 1;
            int sizeR = end - middle;

            int[] L = new int[sizeL];
            int[] R = new int[sizeR];

            for (int h = 0; h < sizeL; h++)
                L[h] = array[start + h];
            for (int h = 0; h < sizeR; h++)
                R[h] = array[middle + h + 1];

            int i = 0, j = 0, k = start;

            while (i < sizeL && j < sizeR)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < sizeL)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < sizeR)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
