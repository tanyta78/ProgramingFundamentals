using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class EValidUsernames
    {
        public static void Main()
        {

            string[] wordsInput = Console.ReadLine().Split(new char[] { '\\', '/', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";
            Regex wordreg = new Regex(pattern);
            List<string> wordsValid = new List<string>();
            foreach (var word in wordsInput)
            {
                bool match = wordreg.IsMatch(word);
                if (match)
                {

                    wordsValid.Add(word);
                }
            }
            int sumMax = 0;
            string first = String.Empty;
            string second = String.Empty;

            for (int i = 1; i < wordsValid.Count; i++)
            {
                int currentSum = wordsValid[i - 1].Length + wordsValid[i].Length;
                if (currentSum > sumMax)
                {
                    sumMax = currentSum;
                    first = wordsValid[i - 1];
                    second = wordsValid[i];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);


        }
    }
}