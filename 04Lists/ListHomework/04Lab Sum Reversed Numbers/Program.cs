using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Lab_Sum_Reversed_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {

            //            Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
            //Examples
            //Input   Output Comments
            //123 234 12  774 321 + 432 + 21 = 774

            List<string> input = Console.ReadLine()
                                .Split(' ')
                                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = Reverse(input[i]);
            }
            
            int sumOfInputElements = input.Select(int.Parse).ToList().Sum();
            Console.WriteLine(sumOfInputElements);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

