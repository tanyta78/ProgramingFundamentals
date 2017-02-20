using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] numbersInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var num in numbersInput)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 1);
                }
                else
                {
                    numbers[num] += 1;
                }

            }

            foreach (var pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
