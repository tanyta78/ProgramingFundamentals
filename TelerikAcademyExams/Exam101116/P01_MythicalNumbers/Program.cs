namespace P01_MythicalNumbers
{
    using System;
   
    public class Program
    {
       public static void Main(string[] args)
       {
           var number = Console.ReadLine();

           var thirdDigit = int.Parse(number[2].ToString());
           var secondDigit = int.Parse(number[1].ToString());
           var firstDigit = int.Parse(number[0].ToString());

           var result = 0m;

           if (thirdDigit==0)
           {
               result = firstDigit * secondDigit;
           }
           else if (thirdDigit > 0 && thirdDigit <= 5)
           {
               result = ((decimal)firstDigit * secondDigit) /(decimal) thirdDigit;
           }
           else if(thirdDigit>5)
           {
               result = (decimal) (firstDigit + secondDigit )* thirdDigit;
           }

           Console.WriteLine("{0:0.00}", result);

        }
    }
}
