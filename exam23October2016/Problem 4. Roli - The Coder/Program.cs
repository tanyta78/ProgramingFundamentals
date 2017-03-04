using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> idEventName = new Dictionary<string, string>();
            SortedDictionary<string, List<string>> eventParticipants = new SortedDictionary<string, List<string>>();
            while (!input.Equals("Time for Code"))
            {
                string[] eventInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = eventInfo[0];
                string eventName = eventInfo[1].Substring(1);
                List<string> participants = eventInfo.Skip(2).ToList();
                if (eventInfo[1][0].Equals('#'))
                {
                    if (!idEventName.ContainsKey(id))
                    {
                        idEventName.Add(id, eventName);
                    }
                    else
                    {
                        if (idEventName[id] != eventName)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        
                    }

                    if (!eventParticipants.ContainsKey(eventName))
                    {
                        eventParticipants.Add(eventName, participants);
                    }
                    else
                    {
                        // трябва да съдържа само уникални участници!!! да проверявам за повтарящите се eventParticipants[eventName].AddRange(participants);
                        eventParticipants[eventName].AddRange(participants);
                        eventParticipants[eventName] = eventParticipants[eventName].Distinct().ToList();                  }
                }
                input = Console.ReadLine();

            }
            foreach (var evento in eventParticipants.OrderByDescending(p=>p.Value.Count()))
            {
                Console.WriteLine($"{evento.Key} - {evento.Value.Count}");
                foreach (var item in evento.Value.Distinct().OrderBy(x=>x))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}