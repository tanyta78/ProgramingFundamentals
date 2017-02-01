using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates and prints the n! for any n in the range [1…1000].
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger Factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Factorial *= i;
            }
            Console.WriteLine(Factorial);
        }
    }
}
