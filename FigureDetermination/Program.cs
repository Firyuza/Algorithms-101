using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDetermination
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Point> points = new List<Point>();

            Console.WriteLine("Enter 4 points");

            for (var i = 0; i < 4; i++)
            {
                var p = new Point();

                p.X = int.Parse(Console.ReadLine());
                p.Y = int.Parse(Console.ReadLine());

                points.Add(p);
            }

            Console.WriteLine(Figure.DetermineType(points));

            Console.ReadKey();
        }
    }
}
