using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double linebase  = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area =  CalculateAreaOfTrangle(linebase, height);

            Console.WriteLine(area);
        }

        static double CalculateAreaOfTrangle(double linebase, double height)
        {
            return linebase * height / 2;
        }
    }
}
