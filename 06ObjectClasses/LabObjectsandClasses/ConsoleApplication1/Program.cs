namespace _5.ClosestTwoPoints
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
            int numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> points = ReadPoints(numberOfPoints);

            double minDistance = double.MaxValue;

            Point[] closesPoints = null;
            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i + 1; j < numberOfPoints; j++)
                {
                    double result = CalculateDistance(points[i], points[j]);
                    if (result < minDistance)
                    {
                        closesPoints = new Point[] { points[i], points[j] };
                        minDistance = result;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            foreach (var point in closesPoints)
            {
                Console.WriteLine($"({point.x},{point.y})");
            }
            
        }

        private static List<Point> ReadPoints(int numberOfPoints)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < numberOfPoints; i++)
            {
                Point currentPoint = ReadPoint();
                points.Add(currentPoint);
            }
            return points;
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
