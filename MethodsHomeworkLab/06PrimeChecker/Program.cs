namespace _06PrimeChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ////Write a Boolean method IsPrime(n) that check whether a given longeger number n is prime.
            long number = long.Parse(Console.ReadLine());
            bool result = IsPrime(number);
            Console.WriteLine(result);
        }

        public static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n < 2)
            {
                isPrime = false;
            }
            else
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
