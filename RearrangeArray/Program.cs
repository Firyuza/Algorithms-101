/*
 * Google interview

Rearrange characters in a string so that no character repeats twice in a raw.

Input: aaabc
Output: abaca

Input: aa
Output: No valid output

Input: aaaabc
Output: No valid output
 */
using System;
namespace RearrangeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entert string");

            var str = Console.ReadLine();

            Console.WriteLine("Result:");

            Console.WriteLine(Rearrange.ReArray(str));

            Console.ReadKey();
        }
    }
}
