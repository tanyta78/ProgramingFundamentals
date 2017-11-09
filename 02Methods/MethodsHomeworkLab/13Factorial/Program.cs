namespace _13Factorial
{
    using System;
    using System.Numerics;

  public class Program
    {
       public static void Main(string[] args)
        {
            ////Write a program that calculates and prints the n! for any n in the range [1…1000].
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
