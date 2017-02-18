namespace _4.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////You are given a sequence of strings, each on a new line, unitll you receive “stop” command.First string is a name of a person. On the second line you receive his email. 
            ////Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk"(case insensitive).
            ////Print:{ name} – > { email}
            Dictionary<string, string> contactInfo = new Dictionary<string, string>();
            string personName = Console.ReadLine();

            while (!personName.Equals("stop"))
            {
                string personEmail = Console.ReadLine();
                if (!personEmail.Contains(".uk") && !personEmail.Contains(".us"))
                {
                    contactInfo[personName] = personEmail;
                }

                personName = Console.ReadLine();
            }

            foreach (var pair in contactInfo)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
