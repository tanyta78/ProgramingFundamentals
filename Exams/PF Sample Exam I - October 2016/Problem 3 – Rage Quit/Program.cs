using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(input);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {

                int count = int.Parse(matches[i].Groups[2].ToString());
                string text = matches[i].Groups[1].ToString().ToUpper();
                for (int j = 0; j < count; j++)
                {
                    result.Append(text);
                }
               
            }
            var uniqueSymbols = result.ToString().ToCharArray().Distinct();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count()}");
            Console.WriteLine(result);
        }
    }
}
