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
            Heap.Heap heap = new Heap.Heap();

            heap.ConstroiHeap(array);
            Utils.Print(heap.H.ToArray());

            heap.RemoveDaHeap();
            Utils.Print(heap.H.ToArray());

            heap.InserenaHeap(10, 10);
            Utils.Print(heap.H.ToArray());

            heap.AlteraHeap(3, 100);
            Utils.Print(heap.H.ToArray());

            Console.ReadLine();
        }
    }
}
