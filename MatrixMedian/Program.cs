/*
 * Google interview

You are given a matrix n rows, m columns where each row is sorted in increasing order. Find median of the overall elements.
 */
using System;

namespace MatrixMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers of row");

            var rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns");

            var columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter matrix");

            int[][] matrix = new int[rows][];

            for (var i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
            }

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Median median = new Median();

            Console.WriteLine(median.GetMedian(rows, columns, matrix));

            Console.ReadKey();
        }
    }
}
