namespace _4.Split_by_Word_Casing
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
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> upperWords = new List<string>();
            List<string> lowerWords = new List<string>();
            List<string> mixedWords = new List<string>();
            ////check letters in words
            foreach (var word in words)
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasSymbol = false;
                foreach (var ch in word)
                {
                    if (char.IsLower(ch))
                    {
                        hasLower = true;
                    }
                    else if (char.IsUpper(ch))
                    {
                        hasUpper = true;
                    }
                    else if (!char.IsLetter(ch))
                    {
                        hasSymbol = true;
                    }
                                        
                }
                if (hasLower && hasUpper||hasSymbol)
                {
                    mixedWords.Add(word);
                }
                else
                {
                    if (hasLower)
                    {
                        lowerWords.Add(word);
                    }
                    else if (hasUpper)
                    {
                        upperWords.Add(word);
                    }
                    
                }
            }
            ////print results
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));
        }
    }
}
