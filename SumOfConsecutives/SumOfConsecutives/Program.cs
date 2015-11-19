using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SumOfConsecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 3, 5, 7, 9};

            TargetSum Sum = new TargetSum();
            
            Sum.FindTargerConseq(a, 2);

            Console.ReadKey();
        }
    }
}
