namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ////Write a program to read an array of integers, reverse it and print its elements. 
            ////The input consists of a number n (the number of elements) + n integers, each as a separate line. 
            ////Print the output on a single line (space separated).

            int numberOfElements = int.Parse(Console.ReadLine());
            int[] numberArray = new int[numberOfElements];

            for (int index = numberOfElements - 1; index >= 0; index--)
            {
                numberArray[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}
