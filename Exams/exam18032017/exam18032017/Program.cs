using System;

namespace exam18032017
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int numberOfCombinations = 0;
            bool isMagic = false;
            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    numberOfCombinations++;
                    if (i + j == magicNum && !isMagic)
                    {
                        isMagic = true;
                        Console.WriteLine($"Combination N:{numberOfCombinations} ({i} + {j} = {magicNum})");
                    }

                }
            }

            if (!isMagic)
            {
                Console.WriteLine($"{numberOfCombinations} combinations - neither equals {magicNum}");
            }

        }
    }
}
