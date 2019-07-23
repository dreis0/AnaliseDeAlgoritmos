using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo.Sorts
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        public static void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                Sort(array, start, middle);
                Sort(array, middle + 1, end);

                Merge(array, start, middle, end);
            }
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int sizeA = middle - start;
            int sizeB = end - middle;

            int[] A = new int[sizeA];
            int[] B = new int[sizeB];

            for (int h = 0; h < sizeA; h++)
                A[h] = array[start + h];
            for (int h = 0; h < sizeB; h++)
                B[h] = array[middle + h];

            int i = 0, j = 0, k = start;

            while (i < sizeA && j < sizeB)
            {
                if (A[i] <= B[j])
                {
                    array[k] = A[i];
                    i++;
                }
                else
                {
                    array[k] = B[j];
                    j++;
                }
                k++;
            }

            while (i < sizeA)
            {
                array[k] = A[i];
                i++;
                k++;
            }
            while (j < sizeB)
            {
                array[k] = B[j];
                j++;
                k++;
            }
        }
    }
}
