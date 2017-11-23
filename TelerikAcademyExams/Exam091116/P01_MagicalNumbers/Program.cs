namespace P01_MagicalNumbers
{
    using System;

    public class Program
    {
       public static void Main(string[] args)
       {
           var number = Console.ReadLine();

           var firstDigit = int.Parse(number[0].ToString());
           var secondDigit = int.Parse(number[1].ToString());
           var thirdDigit = int.Parse(number[2].ToString());

           var result = 0d;

           if (secondDigit % 2 == 0)
           {
               result = (firstDigit + secondDigit) * thirdDigit;
           }
           else
           {
               result = (double)(firstDigit * secondDigit) / thirdDigit;
           }

          Console.WriteLine("{0:0.00}", result);
        }
    }
}
