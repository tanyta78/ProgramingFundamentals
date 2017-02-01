namespace _07PremierRange
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            //// Write a method that calculates all prime numbers in given range and returns them as list of integers:
            ////static List<int> FindPrimesInRange(startNum, endNum)
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            PrintListOfPrimes(startNum, endNum);
        }

        public static void PrintListOfPrimes(int startNum, int endNum)
        {
            List<int> lst = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i]);
                if (i < lst.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> prime = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                double rootNum = Math.Sqrt((double)i);
                for (int num = 2; num <= rootNum; num++)
                {
                    if (i % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    prime.Add(i);
                }
            }

            return prime;
        }
    }
}