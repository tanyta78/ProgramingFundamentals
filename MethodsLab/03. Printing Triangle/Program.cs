using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }

        private static void PrintTriangle(int num)
        {
            for (int row = 1; row <= num; row ++)
            {
                PrintRow(1,row);
            }
            for (int row = num-1; row >= 1; row--)
            {
                PrintRow(1,row);
            }
        }

        private static void PrintRow(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
