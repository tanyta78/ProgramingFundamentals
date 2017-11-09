using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main()
        {
            string[] bannedList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder(text);

            foreach (string bannedWord in bannedList)
            {
                string mask = new string('*', bannedWord.Length);
                result.Replace(bannedWord, mask);
            }

            Console.WriteLine(result.ToString());
        }
        public void BannedRemove()
        {
            string[] filter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in filter)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}

