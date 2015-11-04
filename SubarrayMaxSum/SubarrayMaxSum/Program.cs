/*
 * We have an array of positive and negative integers. Please find the continous subarray with maximal sum of it's elements.
 */
using System;

namespace SubarrayMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Subarray.GetMaxSum(new int[] { -2, 5, -7, 10, -12, 10 });

            Console.ReadLine();
        }
    }
}
