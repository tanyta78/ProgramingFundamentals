namespace _14FactorialZeros
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = Factorial(number);
            Console.WriteLine(ReturnNumofZeros(number));
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int ReturnNumofZeros(int n)
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
