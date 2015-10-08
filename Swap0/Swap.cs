namespace Swap0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Swap
    {
        private int[] A;
        private int[] B;
        private int Count;
        private int Position0;
        private IDictionary<int, int> IncorrectPlace;

        public Swap(int n, int[] a, int[] b)
        {
            Count = n;
            A = a;
            B = b;

            IncorrectPlace = new Dictionary<int, int>();

            for (var i = 0; i < Count; i++)
            {
                IncorrectPlace.Add(a[i], i);
            }

            var find = false;
            var j = 0;
            while (j < Count && !find)
            {
                if (a[j] == 0)
                {
                    Position0 = j;
                    find = true;
                }

                j++;
            }
        }

        public void Swap0()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                Console.WriteLine("0 =>" + B[Position0]);

                A[Position0] = B[Position0];

                A[IncorrectPlace[B[Position0]]] = 0;

                Position0 = IncorrectPlace[B[Position0]];
            }
        }
    }
}
