using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to read an array of real numbers (space separated values), 
            //round them to the nearest integer in “away from 0” style and print the output as in the examples below.
            double[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(double.Parse)
                        .ToArray();
            int[] roundNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundNumbers[i] =(int) Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {roundNumbers[i]}");
            }
            
        }
    }
}
