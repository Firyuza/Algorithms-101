using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            var str = Console.ReadLine();

            Parentheses.Balance(str);

            Console.ReadKey();
        }
    }
}
