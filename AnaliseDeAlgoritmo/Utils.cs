using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo
{
    public static class Utils
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (i != array.Length - 1)
                    Console.Write($"{array[i]}, ");
                else
                    Console.WriteLine(array[i]);
        }
    }
}
