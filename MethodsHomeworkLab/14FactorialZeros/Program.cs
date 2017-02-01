using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14FactorialZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger FactorialNumber = Factorial(number);
            Console.WriteLine(ReturnNumofZeros(number));
           


        }
        static BigInteger Factorial(int n)
        {
            BigInteger Factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Factorial *= i;
            }
            return Factorial;
        }
        static int ReturnNumofZeros(int n)
        {
            int timesZero = 0;

            for (int numb = 5; numb <= n; numb *= 5)
            {
                timesZero += n / numb;
            }
            return timesZero;
        }
    }
}
