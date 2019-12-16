namespace Application.Heap
{
    public class Heap : IHeap<int>
    {
        public HeapItem<int>[] H { get; set; }

        public void ConstroiHeap(int[] array)
        {
            H = array.ToHeap();

            for (int i = (array.Length / 2) - 1; i >= 0; i--)
                CorrigeHeapDescendo(i);
        }

        public void RemoveDaHeap()
        {
            if (H.Length > 0)
            {
                H[0] = H[H.Length - 1];
                CorrigeHeapDescendo(0);
            }

            HeapItem<int>[] novaHeap = new HeapItem<int>[H.Length - 1];

            for (int i = 0; i < novaHeap.Length; i++)
                novaHeap[i] = H[i];

            H = novaHeap;
        }

        public void InserenaHeap(int valor, int prioridade)
        {
            HeapItem<int>[] novaHeap = new HeapItem<int>[H.Length + 1];
            for (int i = 0; i < H.Length; i++)
                novaHeap[i] = H[i];

            novaHeap[H.Length] = new HeapItem<int>() { Value = valor, Prioridade = prioridade };
            H = novaHeap;

            CorrigeHeapSubindo(novaHeap.Length - 1);
        }

        public void AlteraHeap(int i, int novaPrioridade)
        {
            int aux = H[i].Prioridade;
            H[i].Prioridade = novaPrioridade;

            if (aux < novaPrioridade) CorrigeHeapSubindo(i);
            else if (aux > novaPrioridade) CorrigeHeapDescendo(i);
        }

        public void CorrigeHeapDescendo(int i)
        {
            int maior = i, esquerda = 2 * i + 1, direita = 2 * i + 2, n = H.Length;

            if (esquerda < n && H[esquerda].Prioridade > H[maior].Prioridade)
                maior = esquerda;
            if (direita < n && H[direita].Prioridade > H[maior].Prioridade)
                maior = direita;

            if (maior != i)
            {
                var troca = H[i];
                H[i] = H[maior];
                H[maior] = troca;

                CorrigeHeapDescendo(maior);
            }
        }

        private void CorrigeHeapSubindo(int i)
        {
            int pai = i / 2;

            if (i >= 1 && H[i].Prioridade > H[pai].Prioridade)
            {
                var aux = H[i];
                H[i] = H[pai];
                H[pai] = aux;

                CorrigeHeapSubindo(pai);
            }
        }


    }

    public static class HeapMapper
    {
        public static int[] ToArray(this HeapItem<int>[] H)
        {
            int[] result = new int[H.Length];

            for (int i = 0; i < H.Length; i++)
                result[i] = H[i].Value;

            return result;
        }

        public static HeapItem<int>[] ToHeap(this int[] array)
        {
            HeapItem<int>[] heap = new HeapItem<int>[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                heap[i] = new HeapItem<int>();
                heap[i].Prioridade = array[i];
                heap[i].Value = array[i];
            }
            return heap;
        }
    }
}
