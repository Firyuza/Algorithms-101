/*
Google interview

Given a string representing relative path write a function which normalizes this path (i.e. replaces "..").
Example: input: \a\b\..\foo.txt
output: \a\foo.txt
*/
using System;

namespace NormalizePath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");

            var givenPath = Console.ReadLine();

            Path path = new Path(givenPath);

            Console.WriteLine(path.NormalizePath());

            Console.ReadKey();
        }
    }
}
