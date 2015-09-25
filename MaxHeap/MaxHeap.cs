namespace MaxHeap
{
    using System;

    public class MaxHeap
    {
        private int[] Heap;

        private MaxPQ PQ;

        private int K;

        private int Count;

        public MaxHeap(int[] heap, int k)
        {
            Heap = heap;

            Count = heap.Length;

            K = k;

            PQ = new MaxPQ(Count, Heap);
        }

        public int FindMax()
        {
            var lastMax = Heap[0];

            var i = 0;

            var j = 0;

            var max = 0;
            var min = 0;

            while(j < Count && i != K)
            {
                var left = 2 * j + 1;

                var right = 2 * j + 2;

                if(left < Count)
                {
                    if(right < Count)
                    {
                        if(Heap[left] > Heap[right])
                        {
                            max = left;
                            min = right;
                        }
                        else
                        {
                            max = right;
                            min = left;
                        }

                        if(PQ.GetCount() != 0)
                        {
                            if(Heap[max] > PQ.GetMax())
                            {
                                lastMax = max;
                                i++;

                                PQ.Insert(min);
                            }
                            else
                            {
                                lastMax = PQ.RemoveMax();
                                i++;

                                PQ.Insert(min);
                                PQ.Insert(max);
                            }
                        }
                        else
                        {
                            lastMax = max;
                            i++;

                            PQ.Insert(min);
                        }
                    }
                    else
                    {
                        max = left;

                        if (PQ.GetCount() != 0)
                        {
                            if (Heap[max] > PQ.GetMax())
                            {
                                lastMax = max;
                                i++;
                            }
                            else
                            {
                                lastMax = PQ.RemoveMax();
                                i++;

                                PQ.Insert(max);
                            }
                        }
                        else
                        {
                            lastMax = max;
                            i++;
                        }
                    }

                    j = lastMax;
                }
                else
                {
                    if(i < Count)
                    {
                        lastMax = PQ.RemoveMax();
                        i++;

                        j = lastMax;
                    }
                }
            }

            if(i != K)
            {
                throw new Exception("Something was wrong");
            }
            
            return lastMax;
        }
    }
}
