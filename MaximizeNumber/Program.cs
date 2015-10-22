namespace MaximizeNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of first array");

            var n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first array");

            int[] a = new int[n1];
            for(var i = 0; i < n1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter length of second array");

            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first array");

            int[] b = new int[n2];
            for (var i = 0; i < n2; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            Maximize maxNumbers = new Maximize(n1, a, n2, b);

            maxNumbers.PrintNewArray();

            Console.ReadKey();
        }
    }
}
