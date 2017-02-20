namespace _4.Distance_Between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            Point a = ReadPoint();
            Point b = ReadPoint();

            double result = CalculateDistance(a, b);

            Console.WriteLine($"{result:f3}");
        }

        private static double CalculateDistance(Point a, Point b)
        {
            double firstSide = Math.Abs(b.x - a.x);
            double secondSide = Math.Abs(b.y - a.y);
            double result = Math.Sqrt(firstSide * firstSide + secondSide * secondSide);
            return result;
        }

        private static Point ReadPoint()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point point = new Point();
            point.x = input[0];
            point.y = input[1];
            return point;
        }

        public class Point
        {
            public double x { get; set; }
            public double y { get; set; }




        }
    }
}
