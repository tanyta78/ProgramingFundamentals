using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main()
        {
            int countNumbers = int.Parse(Console.ReadLine());
            List<int> inputNumbers = new List<int>();
            for (int i = 0; i < countNumbers; i++)
            {
                inputNumbers.Add(int.Parse(Console.ReadLine()));
            }
            ////Write a program to read n integers and print their sum, min, max, first, last and average values.
            Console.WriteLine($"Sum = {inputNumbers.Sum()}");
            Console.WriteLine($"Min = {inputNumbers.Min()}");
            Console.WriteLine($"Max = {inputNumbers.Max()}");
            Console.WriteLine($"Average = {inputNumbers.Average()}");
        }
    }
}
