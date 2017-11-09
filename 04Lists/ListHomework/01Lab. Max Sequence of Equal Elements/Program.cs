using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Lab.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.
            List<int> numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> uniqueNumbers = numbers.Distinct().ToList();

            int longestSequence = 1;
            int bestnum = numbers[0];

            foreach (var num in uniqueNumbers)
            {
                int currentSequence = numbers.Count(a => a==num);
                if (currentSequence>longestSequence)
                {
                    longestSequence = currentSequence;
                    bestnum = num;
                }
            }

            List<int> bestSequenceList = numbers.Where(a => a == bestnum).ToList();

            Console.WriteLine(string.Join(" ", bestSequenceList));
        }
    }
}
