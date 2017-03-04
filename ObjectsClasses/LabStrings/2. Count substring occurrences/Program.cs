using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_substring_occurrences
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string part = Console.ReadLine().ToLower();
            int len = part.Length;
            int countSubstrings = 0;
            for (int i = 0; i <= text.Length-len; i++)
            {
                if (text.Substring(i,len).Equals(part))
                {
                    countSubstrings++;
                }
            }
            Console.WriteLine(countSubstrings);
           
        }
    }
}
