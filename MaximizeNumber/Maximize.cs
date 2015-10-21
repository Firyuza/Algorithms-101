using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizeNumber
{
    public class Maximize
    {
        private int[] Array;

        private int ACount;

        private MaxPQ Queue;

        public Maximize(int n1, int[] a, int n2, int[] r)
        {
            ACount = n1;
            Array = a;

            Queue = new MaxPQ(n2, r);
        }

        public void PrintNewArray()
        {
            for (var i = 0; i < ACount; i++)
            {
                if (Queue.GetCount() != 0 && Array[i] < Queue.GetMax())
                {
                    Array[i] = Queue.RemoveMax();
                    Console.Write(Array[i] + ", ");
                }
                else
                {
                    Console.Write(Array[i] + ", ");
                }
            }  
        }
    }
}
