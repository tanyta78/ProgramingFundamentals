namespace _02SignOfInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    
    class SignOfInt
    {
        
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberSign(number);
        }

        private static void PrintNumberSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
