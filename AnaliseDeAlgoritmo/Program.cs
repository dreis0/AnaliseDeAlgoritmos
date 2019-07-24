using System;
using AnaliseDeAlgoritmo.Sorts;

namespace AnaliseDeAlgoritmo
{
    class Program
    {
        /* 
            BubbleSort 
            InsertionSort   - OK
            SelectionSort
            MergeSort       - OK
            QuickSort
            PartitionSort
            HeapSort
         */
        static void Main(string[] args)
        {
            int[] array = { 15, 5, 1, 3, 9, 7, 2, 6, 12, 11 };

            Utils.Print(array);
            MergeSort.Sort(array);
            Utils.Print(array);

            Console.ReadLine();
        }
    }
}
