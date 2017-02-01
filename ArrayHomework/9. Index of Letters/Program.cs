namespace _9.Index_of_Letters
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            char[] letters = new char[26];
            int counter = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters[counter] = i;
                counter++;
            }

            string word = Console.ReadLine().ToLower();
            foreach (var item in word)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (item == letters[i])
                    {
                        Console.WriteLine($"{item} -> {i}");
                    }
                }
            }
        }
    }
}
