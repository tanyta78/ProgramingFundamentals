namespace _02Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            //// Write a program that receives some info from the console about people and their phone numbers.
            ////Each entry should have just one name and one number (both of them strings). 
            ////On each line you will receive some of the following commands:
            ////A { name}{ phone} – adds entry to the phonebook.
            ////In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
            ////S { name} – searches for a contact by given name and prints it in format "{name} -> {number}".
            ////In case the contact isn't found, print "Contact {name} does not exist.".
            ////END – stop receiving more commands.
            ////  Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the command “ListAll”.

            List<string> comandLine = Console.ReadLine().Split(' ').ToList();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string comand = comandLine[0];

            while (!comand.Equals("END"))
            {
                if (comand.Equals("A"))
                {
                    ResultAdd(comandLine, phonebook);
                }

                if (comand.Equals("S"))
                {
                    ResultSearch(comandLine, phonebook);
                }

                if (comand.Equals("ListAll"))
                {
                    PrintPhonebook(phonebook);
                }

                comandLine = Console.ReadLine().Split(' ').ToList();
                comand = comandLine[0];
            }
        }

        private static void PrintPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (var pair in phonebook)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        private static void ResultAdd(List<string> comandLine, SortedDictionary<string, string> phonebook)
        {
            string contactName = comandLine[1];
            string contactPhone = comandLine[2];

            if (phonebook.ContainsKey(contactName))
            {
                phonebook[contactName] = contactPhone;
            }
            else
            {
                phonebook.Add(contactName, contactPhone);
            }
        }

        private static void ResultSearch(List<string> comandLine, SortedDictionary<string, string> phonebook)
        {
            string contactName = comandLine[1];

            if (phonebook.ContainsKey(contactName))
            {
                Console.WriteLine("{0} -> {1}", contactName, phonebook[contactName]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", contactName);
            }
        }
    }
}