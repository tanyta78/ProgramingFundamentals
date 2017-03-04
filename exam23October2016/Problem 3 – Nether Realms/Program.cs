using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3___Nether_Realms
{
    class Program
    {
        static void Main()
        {

            string[] dragonBook = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToArray();
            decimal health = 0;
            decimal damage = 0;
            decimal correct = 1;
            foreach (var dragonName in dragonBook)
            {
                health = 0;
                damage = 0;
                ////calculate health
                string demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
                Regex regex = new Regex(demonHealthPattern);
                MatchCollection collection = regex.Matches(dragonName);
                foreach (Match str in collection)
                {
                    foreach (char letter in str.ToString())
                    {
                        health += (int)letter;

                    }
                }

                ////calculate damage
                string pattern2 = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
                Regex number = new Regex(pattern2);
                var matches = number.Matches(dragonName);
                foreach (var match in matches)
                {
                    damage += decimal.Parse(match.ToString());
                }
                foreach (char c in dragonName.Where(c => c == '*' || c == '/'))
                {
                    if (c == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{dragonName} - {health} health, {damage:f2} damage");
            }
        }
    }
}