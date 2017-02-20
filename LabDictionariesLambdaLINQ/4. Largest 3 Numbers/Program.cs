using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.
            List<double> inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
           List<double>result =  inputNumbers.OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
