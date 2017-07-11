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

            while (true)
            {
                //split input
                string isBroadcast = @"(^[0-9]+) .+ ([a-zA-Z0-9]+)";
                string isPrivatemessage = @"(^[0-9]+) .+ ([a-zA-Z0-9]+)";


                string input = Console.ReadLine();


                if (input.Equals("Hornet is Green"))
                {
                    break;
                }

                //check first part and second part

                Regex broadckastMatch = new Regex(isBroadcast);
                Regex massagematch = new Regex(isPrivatemessage);

                if (massagematch.IsMatch(input))
                {
                    string firstPArt = massagematch.Match(input).Groups[1].ToString();
                    string secondPart = massagematch.Match(input).Groups[2].ToString();

                    //it is private massage


                    // manipulate first and second part if message
                    //If the given data is a private message, the first query is the recipient’s code, and the second query is the message.You must reverse the recipient’s code and store it along with the message.
                    StringBuilder message = new StringBuilder();
                    char[] firstPArtstr = firstPArt.ToCharArray();
                    string reverse = String.Empty;
                    for (long i = firstPArtstr.Length - 1; i > -1; i--)
                    {
                        reverse += firstPArtstr[i];
                    }
                    message.Append(reverse);
                    message.Append(" -> ");
                    message.Append(secondPart);
                    string result = message.ToString();
                    privateMassagesStore.Add(result);
                }

                if (broadckastMatch.IsMatch(input))
                {
                    string firstPArt =broadckastMatch.Match(input).Groups[1].ToString();
                    string secondPart = broadckastMatch.Match(input).Groups[3].ToString();

                    StringBuilder broadcast = new StringBuilder();
                    char[] secondPArtstr = secondPart.ToCharArray();
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
                    broadcast.Append(firstPArt);
                    string result = broadcast.ToString();
                    broadcastStore.Add(result);
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

    }

}

