using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that count the number of pairs in given array which difference is equal to given number.
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int length = numbers.Length;
            int countDifference = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    int currentDifference=Math.Abs(numbers[i]-numbers[j]);
                    if (currentDifference==difference)
                    {
                        countDifference++;
                    }
                }
            }
            Console.WriteLine(countDifference);



        }
    }
}
