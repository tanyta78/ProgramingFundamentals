using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = CalculateNumPower(number, power);

            Console.WriteLine(result);

        }

        private static double CalculateNumPower(double number, double power)
        {
            return Math.Pow(number,power);
        }
    }
}
