using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            //            ////Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
            ////	Use the following separators: . , : ; ( )[ ] " ' \ / ! ? (space).
            ////Use case-insensitive matching.
            ////Remove duplicated words.
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> wordsInput = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToList();

            Console.WriteLine(string.Join(", ", wordsInput.Where(w => w.Count() < 5).OrderBy(x => x).Distinct()));            

        }
    }
}
