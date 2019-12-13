﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo.Sorts
{
    public static class Bubble
    {
        public static void BubbleSort(this IList<int> array)
        {
            array.BubbleSort((a, b) => a > b);
        }

        public static void BubbleSort<T>(this IList<T> array, Func<T, T, bool> comparingFunction)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if (comparingFunction(array[i], array[i + 1]))
                    {
                        swap = true;
                        T aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;
                    }
                }
            }
        }
    }
}