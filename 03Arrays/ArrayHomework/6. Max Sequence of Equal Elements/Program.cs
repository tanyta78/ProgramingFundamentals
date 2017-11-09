namespace _6.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            int length = numbers.Length;
            int maxsequence = 1;
            int startindex = 0;
            int counter = 1;
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                    if (i == length - 1 && maxsequence < counter)
                    {
                        maxsequence = counter;
                    }
                }
                else
                {
                    if (counter > maxsequence)
                    {
                        maxsequence = counter;
                        startindex = i - maxsequence;
                    }

                    counter = 1;
                }
            }

            string[] result = numbers.Skip(startindex).Take(maxsequence).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
