using Application.Sorts;
using Utils.Extensions;
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
            //IList<int> array = new int[] { 3, 9, 1, 2, 7, 4, 8, 5, 0, 6 };
            var array = new int[10];

            array.Randomize()
                .Print()
                .BubbleSort()
                .Print();

            Console.ReadLine();
        }
    }
}
;