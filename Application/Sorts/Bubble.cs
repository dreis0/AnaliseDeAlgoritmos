using System;
using System.Collections.Generic;
using Utils.Extensions;

namespace Application.Sorts
{
    public static class Bubble
    {
        public static IList<int> BubbleSort(this IList<int> array)
        {
            return array.BubbleSort((a, b) => a > b);
        }

        public static IList<T> BubbleSort<T>(this IList<T> array, Func<T, T, bool> comparingFunction)
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
                        array.Swap(i, i + 1);
                    }
                }
            }

            return array;
        }
    }
}
