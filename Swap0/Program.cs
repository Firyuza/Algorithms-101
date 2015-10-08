/*
 * Google interview:

Rearrange an array using swap with 0. 

You have two arrays src, tgt, containing two permutations of the numbers 0..n-1. You would like to rearrange src so that it equals tgt. The only allowed operations is “swap a number with 0”, e.g. {1,0,2,3} -> {1,3,2,0} (“swap 3 with 0”). Write a program that prints to stdout the list of required operations. 

Practical application: 

Imagine you have a parking place with n slots and n-1 cars numbered from 1..n-1. The free slot is represented by 0 in the problem. If you want to rearrange the cars, you can only move one car at a time into the empty slot, which is equivalent to “swap a number with 0”. 

Example: 
src={1,0,2,3}; tgt={0,2,3,1};
 * */
namespace Swap0
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");

            var count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first array");

            int[] a = new int[count];
            for (var i = 0; i < count; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter target array");

            int[] b = new int[count];
            for (var i = 0; i < count; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            Swap swap = new Swap(count, a, b);

            swap.Swap0();

            Console.ReadKey();
        }
    }
}
