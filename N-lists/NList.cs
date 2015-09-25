using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_lists
{
    public class NList
    {
        private int Number { get; set; }

        public NList(int n)
        {
            Number = n;
        }

        public void ShowNList()
        {
            One();

            for(var i = 2; i < Number; i++)
            {
                var r = Number % i;
                var q = Number / i;

                for (var j = 0; j < q; j++)
                {
                    Console.Write(i + " ");
                }

                if (r != 0)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }

        private void One()
        {
            for (var i = 1; i < Number - 1; i++)
            {
                Console.Write(i + " ");

                for(var j = 0; j < Number - i; j++)
                {
                    Console.Write(1 + " ");
                }

                Console.WriteLine();
            }
        }

    }
}
