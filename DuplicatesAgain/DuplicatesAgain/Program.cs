/*
 * Google interview.

We have an array of (n + 1) integers that are in the range 1..n.
Write a function which finds any integer that appears more than once in our array.
Optimize for additional space.
 */
using System;

namespace DuplicatesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap.PrintDuplicates(new int[] {2, 7, 9, 5, 7, 6, 4, 3, 4, 4, 6});
            
            Console.ReadLine();
        }
    }
}
