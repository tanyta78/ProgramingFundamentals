using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NumbersinReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that prints the digits of a given decimal number in a reversed order.
            string number = Console.ReadLine();
            ReverseNumber(number);
            Console.WriteLine();
        }

        private static void ReverseNumber(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}
