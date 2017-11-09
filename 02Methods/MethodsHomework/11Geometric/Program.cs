namespace _11GeometryCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle.
            ////On the first line you will get the figure type. Next you will get parameters for the chosen figure, each on a different line:
            ////Triangle - side and height
            ////Square - side
            ////Rectangle - width and height
            ////Circle - radius
            ////The output should be rounded to the second digit after the decimal point

            string type = Console.ReadLine();
            PrintArea(type);
        }

        public static void PrintArea(string type)
        {
            double Area = 0;
            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Area = side * height / 2;
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Area = side * side;
                    break;
                case "rectangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Area = side * height;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Area = radius * radius * Math.PI;
                    break;
            }

            Console.WriteLine($"{Area:f2}");
        }
    }
}
