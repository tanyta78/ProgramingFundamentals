using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Lab.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<string> commandLine = Console.ReadLine()
                                .Split(' ')
                                .ToList();

            string command = commandLine[0];
            while (command !="print")
            {
                List<int> commandNumbers = commandLine
                                           .Skip(1)
                                           .Select(int.Parse)
                                           .ToList();


                switch (command)
                {
                   case "add":
                        numbers = AddToNumbers(commandNumbers,numbers);
                        break;
                    case "addMany":
                       numbers = AddManyToNumbers(commandNumbers, numbers);
                        break;
                    case "contains":
                        ContainsIndexNumbers(commandNumbers[0], numbers);
                        break;
                    case "remove":
                        numbers = RemoveFromNumbers(commandNumbers[0], numbers);
                        break;
                    case "shift":
                        numbers = ShiftFromNumbers(commandNumbers[0], numbers);
                        break;
                    case "sumPairs":
                        numbers = SumPairsInNumbers( numbers);
                        break;
                }
                commandLine = Console.ReadLine()
                               .Split(' ')
                               .ToList();
                 command = commandLine[0];

            }
            Console.WriteLine($"[{string.Join(", ", numbers).TrimEnd()}]");
        }


        private static List<int> SumPairsInNumbers( List<int> numbers)
        {
            //•	sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
            //o For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
            int len = numbers.Count;
            List<int> result = new List<int>(len); 
            for (int i = 0; i < numbers.Count; i+=2)
            {
                result.Add(numbers[i] + numbers[i + 1]);
            }
  
            return result;
        }

        private static List<int> ShiftFromNumbers(int v, List<int> numbers)
        {
            //•	shift < positions > – shifts every element of the array the number of positions to the left(with rotation).
            List<int> result = numbers.Skip(v).ToList();
            result.AddRange(numbers.Take(v).ToArray());
            return result;
        }

        private static List<int> RemoveFromNumbers(int v, List<int> numbers)
        {
            //•	remove < index > – removes the element at the specified index.
            numbers.RemoveAt(v);
            return numbers;
        }

        private static void ContainsIndexNumbers(int v, List<int> numbers)
        {
            //contains < element > – prints the index of the first occurrence of the specified element(if exists) in the array or - 1 if the element is not found.
            Console.WriteLine(numbers.IndexOf(v));
        }

        private static List<int> AddManyToNumbers(List<int> commandNumbers, List<int> numbers)
        {
            //addMany < index > < element 1 > < element 2 > … < element n > – adds a set of elements at the specified index.

            int index = commandNumbers[0];
            int[] toAdd = commandNumbers.Skip(1).ToArray();
            numbers.InsertRange(index, toAdd);
            return numbers;
        }

        private static List<int> AddToNumbers(List<int> commandNumbers, List<int> numbers)
        {
            //add < index > < element > – adds element at the specified index (elements right from this position inclusively are shifted to the right).
            int index = commandNumbers[0];
            int element = commandNumbers[1];
            numbers.Insert(index, element);
            return numbers;
        }
    }
}
