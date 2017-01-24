using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method GetMax(int a, int b), that returns maximal of two numbers.
            //Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax(…) method you just created.
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
           int max = getMax(firstNumber,secondNumber);
            max = getMax(max, thirdNumber);
            Console.WriteLine(max);

        }

        private static int getMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
    }
}
