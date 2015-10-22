using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDetermination
{
    public class Figure
    {
        public static string DetermineType(IList<Point> points)
        {
            var min = 0;
            var max = 0;

            for (var i = 1; i < points.Count; i++)
            {
                if ((points[i].X < points[min].X) && (points[i].Y < points[min].Y))
                {
                    min = i;
                }

                if ((points[i].X > points[min].X) && (points[i].Y > points[min].Y))
                {
                    max = i;
                }
            }

            var diagonal = (points[max].X - points[min].X) * (points[max].X - points[min].X) + (points[max].Y - points[min].Y) * (points[max].Y - points[min].Y);
            var diagonalSqrt = Math.Sqrt(diagonal);

            int id = 0;

            if (Math.Abs(min - max) > 1)
            {
                id = Math.Abs(min - max) / 2;
            }
            else
            {
                id = min > max ? min + 1 : max + 1;
            }

            var a = (points[max].X - points[id].X) * (points[max].X - points[id].X) + (points[max].Y - points[id].Y) * (points[max].Y - points[id].Y);

            var b = (points[min].X - points[id].X) * (points[min].X - points[id].X) + (points[min].Y - points[id].Y) * (points[min].Y - points[id].Y);

            if (a + b == diagonal)
            {
                if (a == b)
                {
                    return "Square";
                }
                else
                {
                    return "Rectangle";
                }
            }
            else
            {
                return "Not square and not rectangle";
            }
        }
    }
}
