using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
            //     In case of no elements left in the list, print “empty”.
            List<int> numbers = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToList();
            numbers = numbers.Where(num => num > 0).ToList();
            numbers.Reverse();
            if (numbers.Count()==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
