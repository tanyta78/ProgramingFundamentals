namespace _5.Special_Numbers
{
    using System;

    public class Program
    {
      public static void Main()
        {
            ////A number is special when its sum of digits is 5, 7 or 11.Write a program to read an integer n 
            ////and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int digit = i;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
