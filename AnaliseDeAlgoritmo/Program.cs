using AnaliseDeAlgoritmo.Heap;
using AnaliseDeAlgoritmo.Sorts;
using System;

namespace AnaliseDeAlgoritmo
{
    class Program
    {
        /* 
            BubbleSort      - OK
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

            array.Print();
            array.BubbleSort();
            array.Print();

            Console.ReadLine();
        }
    }
}
