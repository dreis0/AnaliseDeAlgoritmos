using System;
using AnaliseDeAlgoritmo.Sorts;

namespace AnaliseDeAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 5, 1, 3, 9, 7, 2, 6, 12, 11 };

            Utils.Print(array);
            MergeSort.Sort(array);
            Utils.Print(array);

            Console.ReadLine();
        }
    }
}
