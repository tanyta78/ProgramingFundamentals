namespace _6.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ////You are given an input in the format:
            ////ip=(ip.Address) message=(A & sample & message) user=(username)
            ////Your task is to parse the ip and the username from the input and for every user, you have to display every ip from which the corresponding user has sent a message and the count of the messages sent with the corresponding ip.In the output, the usernames must be sorted alphabetically while their ip addresses should be displayed in the order of their first appearance. The output should be in the following format:username: 
            //  ip => count, ip => count…

            List<string> input = Console.ReadLine().Split(' ').ToList();

            var usersInputBook = new SortedDictionary<string, Dictionary<string, int>>();

            while (!input[0].Equals("end"))
            {
                string ip = input[0].ToString().Remove(0, 3);
                string user = input[2].ToString().Remove(0, 5);
                int counter = 1;


                if (!usersInputBook.ContainsKey(user))
                {
                    usersInputBook.Add(user, new Dictionary<string, int>());
                }

                if (!usersInputBook[user].ContainsKey(ip))
                {
                    usersInputBook[user].Add(ip, counter);
                }
                else
                {
                    usersInputBook[user][ip]++;
                }


                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var user in usersInputBook)
            {
                Console.WriteLine(user.Key + ":");
                foreach (var log in user.Value)
                {

                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }

            }
        }
    }
}