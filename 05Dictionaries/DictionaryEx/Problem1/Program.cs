using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            //            Write a program that receives some info from the console about people and their phone numbers.
            //Each entry should have just one name and one number (both of them strings). 
            //On each line you will receive some of the following commands:
            //•	A { name}{ phone} – adds entry to the phonebook.
            //In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
            //•	S { name} – searches for a contact by given name and prints it in format "{name} -> {number}".
            //In case the contact isn't found, print "Contact {name} does not exist.".
            //•	END – stop receiving more commands.

            List<string> comandLine = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string comand = comandLine[0];

            while (!comand.Equals("END"))
            {
                if (comand.Equals("A"))
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

                if (comand.Equals("S"))
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

                comandLine = Console.ReadLine().Split(' ').ToList();
                comand = comandLine[0];
            }


        }
    }
}
