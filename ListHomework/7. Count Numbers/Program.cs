namespace _7.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            SortedDictionary<int, int> numberCount = new SortedDictionary<int, int>();
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var number in input)
            {
                if (!numberCount.ContainsKey(number))
                {
                    numberCount.Add(number, 1);
                }
                else
                {
                    numberCount[number] += 1;
                }
            }
            foreach (var pair in numberCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
