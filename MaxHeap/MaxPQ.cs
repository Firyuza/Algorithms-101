namespace MaxHeap
{
    using System;

    public class MaxPQ 
    {
        private int[] PQ;

        private int Count = 0;

        private int[] MaxHeap;

        public MaxPQ(int maxCount, int[] maxHeap)
        {
            PQ = new int[maxCount];

            MaxHeap = maxHeap;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public int GetCount()
        {
            return Count;
        }

        public void Insert(int item)
        {
            PQ[Count++] = item;
            Swim(Count - 1);
        }

        public int GetMax()
        {
            return MaxHeap[PQ[0]];
        }

        public int RemoveMax()
        {
            int max = PQ[0];

            Count--;
            Exch(0, Count);

            PQ[Count] = default(int);

            Sink(0);

            return max;
        }

        private void Swim(int k)
        {
            while(k > 0 && Less(k / 2, k))
            {
                Exch(k / 2, k);

                k = k / 2;
            }
        }

        private void Sink(int k)
        {
            while(2 * k  + 1 < Count)
            {
                int j = 2 * k + 1;

                if (j < (Count - 1) && Less(j, j + 1))
                    j++;

                if (!Less(k, j))
                    break;

                Exch(k, j);

                k = j;
            }
        }

        private bool Less(int i, int j)
        {
            return MaxHeap[PQ[i]] < MaxHeap[PQ[j]];
        }

        private void Exch(int i, int j)
        {
            int temp = PQ[i];
            PQ[i] = PQ[j];
            PQ[j] = temp;
        }
    }
}
