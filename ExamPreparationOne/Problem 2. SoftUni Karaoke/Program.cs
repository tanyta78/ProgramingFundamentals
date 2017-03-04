using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_2.SoftUni_Karaoke
{
    class Program
    {
        static void Main()
        {
           
            string pattern = @",\s*";
            string[] participants = Regex.Split(Console.ReadLine(),pattern);
            string[] availableSongs = Regex.Split(Console.ReadLine(), pattern);
            string input = Console.ReadLine();
            SortedDictionary<string, List< string>> karaokeInfo = new SortedDictionary<string, List<string>>();
            while (!input.Equals("dawn"))
            {
                string[] inputInfo = Regex.Split(input,pattern);
                string participant = inputInfo[0].Trim();
                string song = inputInfo[1].Trim();
                string award = inputInfo[2].Trim();

                if (participants.Contains(participant)&&availableSongs.Contains(song))
                {
                    if (!karaokeInfo.ContainsKey(participant))
                    {
                        karaokeInfo.Add(participant, new List<string>());
                    }
                    if (!karaokeInfo[participant].Contains(award))
                    {
                        karaokeInfo[participant].Add(award);
                    }
                }
                
                input = Console.ReadLine();

            }
            if (karaokeInfo.Count==0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var pair in karaokeInfo.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value.Count} awards");
                    foreach (var award in pair.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"--{award}");
                    }
                    
                }
            }
        }
    }
}
