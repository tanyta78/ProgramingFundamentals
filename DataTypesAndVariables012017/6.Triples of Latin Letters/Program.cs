namespace _6.Triples_of_Latin_Letters
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically.

            int number = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < number; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < number; secondLetter++)
                {
                    for (int thirdletter = 0; thirdletter < number; thirdletter++)
                    {
                        Console.WriteLine($"{(char)(firstLetter + 'a')}{(char)(secondLetter + 'a')}{(char)(thirdletter + 'a')}");
                    }
                }
            }
        }
    }
}
