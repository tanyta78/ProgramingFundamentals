namespace _04NumbersinReversedOrder
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            ////Write a method that prints the digits of a given decimal number in a reversed order.
            string number = Console.ReadLine();
            ReverseNumber(number);
            Console.WriteLine();
        }

        public static void ReverseNumber(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}
