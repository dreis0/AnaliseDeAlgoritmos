using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo.Heap
{
    public class HeapItem<T>
    {
        public int Prioridade { get; set; }

        public T Value { get; set; }
    }
}
