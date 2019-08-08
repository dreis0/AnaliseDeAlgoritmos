using AnaliseDeAlgoritmo.Sorts;
using AnaliseDeAlgoritmo.Utils;
using System;
using System.Collections.Generic;

namespace Application
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
            IList<int> array = new int[] { 3, 9, 1, 2, 7, 4, 8, 5, 0, 6 };

            array.Print()
                .MergeSort()
                .Print();

            Console.ReadLine();
        }
    }
}
