using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given the coordinates of two podoubles on a Cartesian coordinate system - X1, Y1, X2 and Y2.
            //Create a method that prdoubles the podouble that is closest to the center of the coordinate system(0, 0) in the format (X, Y).
            //If the podoubles are on a same distance from the center, prdouble only the first one.
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double d1= getDistance(x1,y1);
            double d2 = getDistance(x2,y2);
            if (d1<d2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double getDistance(double x, double y)
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }
    }
}
