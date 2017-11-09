namespace MethodsHomework
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////You are given a text and a number count. Your program should search through the text for the letter 'p' (ASCII code 112) 
            ////and print 'p' along with count letters to its right.
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int startIndex = 0;
            int endIndex = 0;
            bool hasMatch = false;
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    endIndex = i + count + 1;
                    startIndex = i;
                    if (endIndex >= length)
                    {
                        Console.WriteLine(text.Substring(startIndex));
                    }
                    else
                    {
                        Console.WriteLine(text.Substring(startIndex, count + 1));
                    }

                    i = endIndex - 1;
                    continue;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}