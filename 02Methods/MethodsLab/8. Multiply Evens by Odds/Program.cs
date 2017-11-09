using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its odd digits:
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetSumOfDigits(number, 1) * GetSumOfDigits(number, 0);
            Console.WriteLine(result);

        }

        

        private static int GetSumOfDigits(int number,int reminder)
        {
            int sumOfDigits = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit%2==reminder)
                {
                    sumOfDigits += digit;
                }
               
            }
            return sumOfDigits;
        }
    }
}
