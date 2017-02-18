using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    public class Intersection_of_Circles
    {
        public static void Main()
        {
            int[] circleOneParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] circleTwoParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point
            {
                x = circleOneParameters[0],
                y = circleOneParameters[1]
            };
            Circle firstCircle = new Circle
            {
                Radius = circleOneParameters[2],
                Center = firstPoint
            };

            Point secondPoint = new Point
            {
                x = circleTwoParameters[0],
                y = circleTwoParameters[1]
            };
            Circle secondCircle = new Circle
            {
                Radius = circleTwoParameters[2],
                Center = secondPoint
            };

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

public class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
    public static bool Intersect(Circle firstCircle, Circle secondCircle)
    {
        int deltaX = Math.Abs(firstCircle.Center.x - secondCircle.Center.x);
        int deltaY = Math.Abs(firstCircle.Center.y - secondCircle.Center.y);
        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        int radiusdif = firstCircle.Radius + secondCircle.Radius;
        if (distance <= radiusdif)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
public class Point
{
    public int x { get; set; }
    public int y { get; set; }
}

