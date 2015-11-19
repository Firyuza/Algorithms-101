using System;
namespace SumOfConsecutives
{
    public class TargetSum
    {
        private int[] Array;

        private int Count;

        private int Target;

        public void FindTargerConseq(int[] a, int t)
        {
            Array = a;
            Count = a.Length;
            Target = t;

            Find();
        }

        private void Find()
        {
            var id = Count - 1;
            var find = false;
            var curId = id;

            var sum = Array[id];
            id--;
            if (sum != Target)
            {
                while (id >= 0 && !find)
                {
                    if (Array[id] + sum < Target)
                    {
                        sum += Array[id];
                        id--;
                    }
                    else
                    {
                        if (Array[id] + sum == Target)
                        {
                            find = true;
                        }
                        else
                        {
                            curId--;
                            sum = Array[curId];
                            id = curId - 1;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Output: " + Array[id + 1]);
                return;
            }

            if (find)
            {
                Console.WriteLine("Output:");
                for (var i = id; i <= curId; i++)
                {
                    Console.Write(Array[i] + " ,");
                }
            }
            else
            {
                Console.WriteLine("Output: nothing");
            }
        }
    }
}
