using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Boolean method IsPrime(n) that check whether a given longeger number n is prime.
            long number = long.Parse(Console.ReadLine());
            bool result= IsPrime(number);
            Console.WriteLine(result);
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n<2)
            {
                isPrime = false;

            }else
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            
            return isPrime;
        }
    }
}
