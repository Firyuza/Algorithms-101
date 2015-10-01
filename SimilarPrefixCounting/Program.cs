using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarPrefixCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            TrieST prefixes = new TrieST();

            prefixes.Put("abcd", 'a');
            prefixes.Put("ab", 'a');
            prefixes.Put("bcfx", 'b');
            prefixes.Put("bcfd", 'b');

            Console.WriteLine(prefixes.GetCount());

            Console.ReadKey();
        }
    }
}
