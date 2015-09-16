using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            var n = int.Parse(Console.ReadLine());

            NList list = new NList(n);

            Console.WriteLine("Result");

            list.ShowNList();

            Console.ReadKey();
        }
    }
}
