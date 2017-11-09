namespace _9.Extract_Middle_1__2_or_3_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ////Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
            ////n = 1-> 1 element
            ////even n -> 2 elements
            ////odd n -> 3 elements
            ////Create a program that reads an array of integers (space separated values) and prints the middle elements in the format shown in the examples.

            int[] myArray = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            int n = myArray.Length;
            PrintExtractElemens(myArray, n);
        }

        private static void PrintExtractElemens(int[] myArray, int n)
        {
            if (n == 1)
            {
                Console.WriteLine($"{{ {myArray[0]} }}");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine($"{{ {myArray[n / 2 - 1]} , {myArray[n / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {myArray[n / 2 - 1]} , {myArray[n / 2]} , {myArray[n / 2 + 1]} }}");
            }
        }
    }
}
