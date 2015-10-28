/*
Amazon interview

If [a1,a2,a3...,an,b1,b2...bn] is given input change this to [a1,b1,a2,b2.....an,bn], solution should be in-place.
*/
namespace ShuffleArray
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");

            var n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Enter array");
            for (var i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Shuffle.ShuffleArray(a);

            Console.WriteLine("Result:");
            for (var i = 0; i < n; i++)
            {
                Console.Write(a[i] + "; ");
            }

            Console.ReadKey();
        }
    }
}
