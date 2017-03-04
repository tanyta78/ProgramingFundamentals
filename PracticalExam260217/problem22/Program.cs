using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace problem2Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ firstQuery} <-> { secondQuery}
            //If the first query consists only of digits and the second one consists of digits and / or letters, it is a private message.
            //If the first query consists of anything but digits, and the second one consists of letters and / or digits, it is a broadcast.
            //Any input that does NOT follow the format, specified above, should be IGNORED.


            var privateMassagesStore = new List<string>();
            var broadcastStore = new List<string>();
            //check first part and second part
            string isDigit = @"\d+";
            string isLetterOrDigit = @"[0-9a-zA-z]+";
            string isAnythingbutDigit = @"[\D]*";
            Regex digitsMatch = new Regex(isDigit);
            Regex letterOrDigitmatch = new Regex(isLetterOrDigit);
            Regex anythingButDigit = new Regex(isAnythingbutDigit);

            while (true)
            {
                //split input
                string separators = " <-> ";
                string input = Console.ReadLine();
                string[] substrings = Regex.Split(input, separators);

                if (input.Equals("Hornet is Green"))
                {
                    break;
                }

               

                if (digitsMatch.IsMatch(substrings[0]) && letterOrDigitmatch.IsMatch(substrings[1]))
                {
                    ExtractprivateMassage(privateMassagesStore, substrings, digitsMatch, letterOrDigitmatch);
                }

                if (anythingButDigit.IsMatch(substrings[0]) && letterOrDigitmatch.IsMatch(substrings[1]))
                {
                    ExtractBroadcasts(broadcastStore, substrings, letterOrDigitmatch, anythingButDigit);
                }

            }
            //print

            if (broadcastStore.Count == 0 && privateMassagesStore.Count == 0)
            {

                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                if (broadcastStore.Count == 0)
                {

                    Console.WriteLine("None");
                }
                else
                {

                    foreach (var item in broadcastStore)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("Messages:");
                if (privateMassagesStore.Count == 0)
                {

                    Console.WriteLine("None");
                }
                else
                {

                    foreach (var item in privateMassagesStore)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void ExtractBroadcasts(List<string> broadcastStore, string[] substrings, Regex letterOrDigitmatch, Regex anythingButDigit)
        {
            Match firstPArt = anythingButDigit.Match(substrings[0]);
            Match secondPart = letterOrDigitmatch.Match(substrings[1]);
            if ((firstPArt.Length == substrings[0].Length) && (secondPart.Length == substrings[1].Length))
            {
                //it is a broadcast
                // manipulate first and second part if broadcast
                // If the given data is a broadcast, the first query is the message, and the second query is the frequency.You must take the frequency and make all capital letters – small and all small letters – capital.Then you must store it, along with the message.
                StringBuilder broadcast = new StringBuilder();
                char[] secondPArtstr = secondPart.ToString().ToCharArray();
                string changeLetters = String.Empty;
                for (long i = secondPArtstr.Length - 1; i > -1; i--)
                {
                    if (char.IsLetter(secondPArtstr[i]))
                    {
                        if (char.IsLower(secondPArtstr[i]))
                        {
                            secondPArtstr[i] = char.ToUpper(secondPArtstr[i]);
                        }
                        else
                        {
                            secondPArtstr[i] = char.ToLower(secondPArtstr[i]);
                        }
                    }
                    changeLetters = secondPArtstr[i] + changeLetters;
                }
                broadcast.Append(changeLetters);
                broadcast.Append(" -> ");
                broadcast.Append(firstPArt.ToString());
                string result = broadcast.ToString();
                broadcastStore.Add(result);

            }
        }

        private static void ExtractprivateMassage(List<string> privateMassagesStore, string[] substrings, Regex digitsMatch, Regex letterOrDigitmatch)
        {
            Match firstPArt = digitsMatch.Match(substrings[0]);
            Match secondPart = letterOrDigitmatch.Match(substrings[1]);
            if ((firstPArt.Length == substrings[0].Length) && (secondPart.Length == substrings[1].Length))
            {
                //it is private massage


                // manipulate first and second part if message
                //If the given data is a private message, the first query is the recipient’s code, and the second query is the message.You must reverse the recipient’s code and store it along with the message.
                StringBuilder message = new StringBuilder();
                char[] firstPArtstr = firstPArt.ToString().ToCharArray();
                string reverse = String.Empty;
                for (long i = firstPArtstr.Length - 1; i > -1; i--)
                {
                    reverse += firstPArtstr[i];
                }
                message.Append(reverse);
                message.Append(" -> ");
                message.Append(secondPart.ToString());
                string result = message.ToString();
                privateMassagesStore.Add(result);

            }
        }
    }
}
