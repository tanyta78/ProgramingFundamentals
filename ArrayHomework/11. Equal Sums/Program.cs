namespace _11.Equal_Sums
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////Write a program that determines if there exists an element in the array 
            ////such that the sum of the elements on its left is equal to the sum of the elements on its right.
            ////If there are no elements to the left / right, their sum is considered to be 0.
            ////Print the index that satisfies the required condition or “no” if there is no such index.

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = numbers.Length;
            int leftsum = 0;
            int rightsum = 0;
            bool isSum = false;

            for (int i = 0; i < length; i++)
            {
                leftsum = numbers.Take(i).ToArray().Sum();
                rightsum = numbers.Skip(i + 1).Take(length - 1 - i).ToArray().Sum();
                if (leftsum == rightsum)
                {
                    Console.WriteLine(i);
                    isSum = true;
                }
            }

            if (!isSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
