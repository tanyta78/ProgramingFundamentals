namespace _17DebugExBePositive
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');

                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] != "")
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];
                    //// You need to check each number, if it’s positive – print it on the console;
                    ////if it’s negative, add to its value the value of the next number and only print the result if it’s not negative.
                    ////You only perform the addition once, 
                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum);
                        Console.Write(" ");
                        found = true;
                    }
                    else
                    {
                        if (j != numbers.Count - 1)
                        {
                            currentNum += numbers[j + 1];
                        }

                        if (currentNum >= 0)
                        {
                            Console.Write(currentNum);
                            Console.Write(" ");

                            found = true;
                        }

                        j++;
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }

                Console.WriteLine();
            }
        }
    }
}
