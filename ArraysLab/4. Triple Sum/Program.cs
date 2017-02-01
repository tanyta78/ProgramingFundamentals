using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c (where a stays left from b). 
            //Print “No” if no such triples exist.
            int[] myArr = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            bool isTriple = false;
            for (int a = 0; a < myArr.Length; a++)
            {
                for (int b = a + 1; b < myArr.Length; b++)
                {
                    int sum = myArr[a] + myArr[b];

                    if (myArr.Contains(sum))
                    {
                        Console.WriteLine($"{myArr[a]} + {myArr[b]} == {sum}");
                        isTriple = true;
                    }

                }

            }

            if (!isTriple)
            {
                Console.WriteLine("No");
            }
        }
    }

}


