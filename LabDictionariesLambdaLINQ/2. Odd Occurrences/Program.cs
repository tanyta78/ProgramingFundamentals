using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            List<string> wordsInput = Console.ReadLine().Split(' ').Select(w => w.ToLower()).ToList();
            foreach (var word in wordsInput)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 1);
                }
                else
                {
                    wordsCount[word] += 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var pair in wordsCount.Where(x => x.Value%2==1))
            {
                result.Add(pair.Key);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
