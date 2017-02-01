using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of strings, reverse it and print its elements.
            //The input consists of a sequence of space separated strings. 
            // Print the output on a single line (space separated).
            string[] myArray = Console.ReadLine()
                                .Split(' ')
                                .ToArray();
            string[] reversedArray = new string[myArray.Length];

            for (int i = 0; i < myArray.Length ; i++)
            {
                reversedArray[i] = myArray[myArray.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedArray));





        }
    }
}
