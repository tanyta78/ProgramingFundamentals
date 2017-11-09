namespace _9.Refactor_Special_Numbers
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            bool isEqual = false;

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                int currency = currentNumber;
                while (currentNumber > 0)
                {
                    sumDigits += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                isEqual = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine($"{currency} -> {isEqual}");
                sumDigits = 0;
                currentNumber = currency;
            }
        }
    }
}
