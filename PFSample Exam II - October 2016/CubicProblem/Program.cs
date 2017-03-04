using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CubicProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";
            Regex codeCheck = new Regex(pattern);
            string input = Console.ReadLine();

            while (!input.Equals("Over!"))
            {
                int textLength = int.Parse(Console.ReadLine());
                Match match = codeCheck.Match(input);
                if (!match.Groups[0].ToString().Equals(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (match.Groups[2].Length != textLength)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string text = match.Groups[2].ToString();
                StringBuilder codeMassage = new StringBuilder();
                for (int i = 0; i < match.Groups[1].Length; i++)
                {

                    if (!char.IsDigit(match.Groups[1].ToString()[i]))
                    {
                        continue;
                    }
                    int currentIndex = match.Groups[1].ToString()[i] - '0';
                    if (currentIndex >= textLength)
                    {
                        codeMassage.Append(' ');
                    }
                    else
                    {
                        codeMassage.Append(text[currentIndex]);
                    }

                }
                for (int i = 0; i < match.Groups[3].Length; i++)
                {
                    if (!char.IsDigit(match.Groups[3].ToString()[i]))
                    {
                        continue;
                    }
                    int currentIndex = match.Groups[3].ToString()[i] - '0';
                    if (currentIndex >= textLength)
                    {
                        codeMassage.Append(' ');
                    }
                    else
                    {
                        codeMassage.Append(text[currentIndex]);
                    }
                }
                Console.WriteLine($"{text} == {codeMassage}");


                input = Console.ReadLine();
            }
        }
    }
}