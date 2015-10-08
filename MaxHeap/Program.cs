/*
Google interview:

Given a max-heap represented as an array, return the kth largest element without modifying the heap. 
I was asked to do it in linear time, but was told it can be done in log time.
*/

namespace MaxHeap
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in max-heap");

            int count = int.Parse(Console.ReadLine());

            int[] maxHeap = new int[count];

            Console.WriteLine("Enter elements with enter");

            for(var i = 0; i < count; i++)
            {
                maxHeap[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter k - index of k-th largest element");

            var k = int.Parse(Console.ReadLine());

            MaxHeap heap = new MaxHeap(maxHeap, k);

            var result = heap.FindMax();

            Console.WriteLine("Result: " + maxHeap[result]);

            Console.ReadKey();
        }
    }
}
