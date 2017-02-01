using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] uniquenumbers = numbers.Distinct().ToArray();
            int bestfreq = 0;
            int bestnumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {

                        counter++;
                    }

                }
                if (counter > bestfreq)
                {
                    bestnumber = currentNumber;
                    bestfreq = counter;

                }
            }
                Console.WriteLine(bestnumber);
            }
        }
    }
    