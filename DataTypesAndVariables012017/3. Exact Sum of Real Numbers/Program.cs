namespace _3.Exact_Sum_of_Real_Numbers
{
    using System;

    public class Program
    {
       public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                decimal curentNumber = decimal.Parse(Console.ReadLine());
                sum += curentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
