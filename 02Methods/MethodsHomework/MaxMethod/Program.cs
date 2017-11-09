namespace MaxMethod
{
    using System;

  public class Program
    {
      public static void Main()
        {
            ////Create a method GetMax(int a, int b), that returns maximal of two numbers.
            ////Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax(…) method you just created.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumber, secondNumber);

            max = GetMax(max, thirdNumber);
            Console.WriteLine(max);
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
