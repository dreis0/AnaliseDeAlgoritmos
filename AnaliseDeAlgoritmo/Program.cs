using AnaliseDeAlgoritmo.Heap;
using AnaliseDeAlgoritmo.Sorts;
using System;

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
            int[] array = { 3, 1, 5, 8, 2, 4, 7, 6, 9 };

            Utils.Print(array);

            array.InsertionSort();
            //MergeSort.Sort(array);

            Utils.Print(array);

            Console.ReadLine();
        }
    }
}
