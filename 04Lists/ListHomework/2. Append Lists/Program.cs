namespace _2.Append_Lists
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
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<List<int>> result = new List<List<int>>();
            int len = input.Count;
            for (int i = 0; i < len; i++)
            {
                List<int> currentList = input[len - 1 - i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
               
                result.Add(currentList);
            }
            foreach (var item in result)
            {
                Console.Write(string.Join(" ", item));
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
