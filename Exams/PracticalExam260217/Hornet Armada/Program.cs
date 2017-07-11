using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {

            //            You will be given N – an longeger.
            //On the next N lines you will be given input containing information about soldiers in the following format:
            //            { lastActivity} = { legionName} -> { soldierType}:{ soldierCount}
            //            The last activity is an longeger.The legion name and soldier type, will both be strings.The soldier count will be an longeger.You must store every legion with its activity, and every soldier type with its count, in its legion.
            //If a given legion already exists, you must add the new soldier type, with its count.If the soldier type exists ALSO, you should just add the soldier count. 
            //IN BOTH cases, stated above, you should update the last activity, with the newly entered one, ONLY if the entered one is GREATER than the previous one.
            //After you’ve read all N input lines, you will receive a line in one of the following formats:
            //•	{ activity}\{ soldierType}
            //•	{ soldierType}
            //            In the first case, you must prlong all legions, and the count of soldiers they have from the given soldier type, who’s last activity is LOWER than the given activity. The legions must be prlonged in descending order by soldier count.
            //            In the second case, you must prlong all legions which have the given soldier type, with last activity, and legion name.The legions must be prlonged in descending order of their activity.


            //        legion name =  last activity = 
            //legion name = soldier type /soldiercount
            long numberForInput = long.Parse(Console.ReadLine());
            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionInfo = new Dictionary<string, Dictionary<string, long>>();
            for (long i = 0; i < numberForInput; i++)
            {
                string input = Console.ReadLine();
                //{ lastActivity} = { legionName} -> { soldierType}:{ soldierCount}
                string[] legionInput = input.Split('=').ToArray();
                long lastActivity = long.Parse(legionInput[0].Trim());
                string[] legNAme = legionInput[1].Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string legionName = legNAme[0].Trim();
                string soldierType = legNAme[1].Split(':').ToArray()[0].Trim();
                long soldierCount = long.Parse(legNAme[1].Split(':').ToArray()[1].Trim());

                //Console.WriteLine();
                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, lastActivity);
                }
                else
                {
                    if (legionActivity[legionName] < lastActivity)
                    {
                        legionActivity[legionName] = lastActivity;
                    }

                }
                if (!legionInfo.ContainsKey(legionName))
                {
                    legionInfo.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionInfo[legionName].ContainsKey(soldierType))
                {
                    legionInfo[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionInfo[legionName][soldierType] = legionInfo[legionName][soldierType] + soldierCount;
                }
            }






            string nextInput = Console.ReadLine();
            //In the first case, you must prlong all legions, and the count of soldiers they have from the given soldier type, who’s last activity is LOWER than the given activity. The legions must be prlonged in descending order by soldier count.
            // In the second case, you must prlong all legions which have the given soldier type, with last activity, and legion name.The legions must be prlonged in descending order of their activity.

            Dictionary<string, long> firstTypeOutput = new Dictionary<string, long>();
            Dictionary<string, long> secondTypeOutput = new Dictionary<string, long>();

            if (nextInput.Contains('\\'))
            {
                //activity and soldier
                long wantedActivity = long.Parse(nextInput.Split('\\')[0]);
                string wantedSoldierType = nextInput.Split('\\')[1];
                //to do prlong

                foreach (var item in legionInfo)
                {
                    if (legionActivity[item.Key] < wantedActivity)
                    {
                        if (!firstTypeOutput.ContainsKey(item.Key) && legionInfo[item.Key].ContainsKey(wantedSoldierType))
                        {
                            firstTypeOutput.Add(item.Key, legionInfo[item.Key][wantedSoldierType]);
                        }
                    }
                }
                foreach (var item in firstTypeOutput.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }


            }
            else
            {
                //soldiertype
                string wantedSoldierType = nextInput;
                //to do prlong
                foreach (var item in legionInfo.Where(x => (x.Value).ContainsKey(wantedSoldierType)))
                {
                    long lastActivity = legionActivity[item.Key];
                    string legionName = item.Key;
                    if (!secondTypeOutput.ContainsKey(legionName))
                    {
                        secondTypeOutput.Add(legionName, lastActivity);
                    }
                }
                foreach (var item in secondTypeOutput.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
              
            }

        }
    }
}

