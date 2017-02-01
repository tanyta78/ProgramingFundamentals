namespace LastDigitName
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            ////Write a method that returns the English name of the last digit of a given number.
            ////Write a program that reads an longeger and prlongs the returned value from this method.
            long number = long.Parse(Console.ReadLine());
            DigitName(number);
        }

       public static void DigitName(long number)
        {
            long lastdigit = Math.Abs(number % 10);
            switch (lastdigit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eigth");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}
