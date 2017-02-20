using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger resultFactorial = 1;
            for (int i = 2; i <= input; i++)
            {
                resultFactorial *= i;
            }
            Console.WriteLine(resultFactorial);
        }
    }
}
