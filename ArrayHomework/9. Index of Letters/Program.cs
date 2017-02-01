using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] letters = new char[26];
            int counter = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters[counter] = i;
                counter++;
            }

            //Console.WriteLine( string.Join("," , letters));
            string word = Console.ReadLine().ToLower();
            foreach (var item in word)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (item == letters[i])
                    {
                        Console.WriteLine($"{item} -> {i}");
                    }
                }
            }
        }
    }
}
