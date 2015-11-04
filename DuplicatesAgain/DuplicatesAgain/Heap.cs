using System;

namespace DuplicatesAgain
{
    public class Heap
    {
        private static int[] Arr;
        private static int Count;
        public static void PrintDuplicates(int[] a)
        {
            Arr = a;
            Count = a.Length;

            Sort();

            var i = 1;
            var first = true;
            while(i < Count - 1)
            {
                if (Arr[i] == Arr[i + 1])
                {
                    if (first)
                    {
                        Console.WriteLine(Arr[i]);
                        first = false;
                    }
                }
                else
                {
                    first = true;
                }

                i++;
            }
        }

        private static void Sort()
        {
            for (var k = Count / 2; k >= 0; k--)
            {
                Sink(k, Count);
            }

            for (var i = Count - 1; i > 0; i--)
            {
                Exch(0, i);
                Sink(0, i - 1);
            }
        }

        private static void Sink(int k, int N)
        {
            while (2 * k + 1 < N)
            {
                int j = 2 * k + 1;

                if (j < (N - 1) && Less(j, j + 1))
                    j++;

                if (!Less(k, j))
                    break;

                Exch(k, j);

                k = j;
            }
        }

        private static bool Less(int i, int j)
        {
            return Arr[i] < Arr[j];
        }

        private static void Exch(int i, int j)
        {
            int temp = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = temp;
        }
    }
}
