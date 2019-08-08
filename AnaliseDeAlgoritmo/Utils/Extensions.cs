using System;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseDeAlgoritmo
{
    public static class Extensions
    {
        public static IList<T> Swap<T>(this IList<T> array, int firstIndex, int SecondIndex)
        {
            T aux = array[firstIndex];
            array[firstIndex] = array[SecondIndex];
            array[SecondIndex] = aux;

            return array;
        }

        public static IList<int> Randomize(this IList<int> array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Count; i++)
                array[i] = rnd.Next(0, 100);

            return array;
        }

        public static IList<double> Randomize(this IList<double> array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Count; i++)
                array[i] = rnd.NextDouble() * 100;

            return array;
        }
    }
}
