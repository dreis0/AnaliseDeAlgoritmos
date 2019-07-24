using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseDeAlgoritmo.Heap
{
    public interface IHeap<T>
    {
        void ConstroiHeap(T[] array);

        void RemoveDaHeap();

        void InserenaHeap(T valor, int prioridade);

        void AlteraHeap(int indice, int novaPrioridade);
    }
}
