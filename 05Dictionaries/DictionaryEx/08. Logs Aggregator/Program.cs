namespace _8.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberLogs = int.Parse(Console.ReadLine());
            var logsData = new SortedDictionary<string, SortedDictionary<string, int>>();
            ////Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]".Order the users alphabetically.Order the IPs alphabetically.In our example, the output should be the following:
            for (int i = 1; i <= numberLogs; i++)
            {
                var accessLogs = Console.ReadLine()
                                    .Split(' ')
                                    .ToList();
                var ip = accessLogs[0];
                var user = accessLogs[1];
                var duration = int.Parse(accessLogs[2]);


                if (!logsData.ContainsKey(user))
                {
                    logsData.Add(user, new SortedDictionary<string, int>());
                }

                if (!logsData[user].ContainsKey(ip))
                {
                    logsData[user].Add(ip, duration);
                }
                else
                {
                    logsData[user][ip] += duration;
                }
            }

            PrintUserLogs(logsData);
        }

        private static void PrintUserLogs(SortedDictionary<string, SortedDictionary<string, int>> logsData)
        {
            foreach (var userEntry in logsData)
            {
                string userName = userEntry.Key;
                int sumDuration = userEntry.Value.Values.Sum();
                List<string> userIPs = userEntry.Value.Keys.ToList();
                Console.WriteLine($"{userName}: {sumDuration} [{string.Join(", ", userIPs)}]");
            }
        }
    }
}
