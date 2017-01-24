using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a cube
            //    (http://www.mathopenref.com/cube.html) by a given side.
            //On the first line you will get the side of the cube. On the second line is given the parameter (face, space, volume or area).
            //Output should be rounded to the second digit after the decimal point
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            PrintResult(side, type);



        }
        static void PrintResult(double side, string type)
        {
            double result = 0.0;
            switch (type)
            {
                case "face":
                    result = Math.Sqrt(2 * side * side);
                    break;
                case "space":
                    result = Math.Sqrt(3 * side * side);
                    break;
                case "volume":
                    result = side * side * side;
                    break;
                case "area":
                    result = 6 * side * side;
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
