using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained. 
            //For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13},
            //then we sum again all adjacent elements and obtain {12+13} = {25}.
            int[] myArr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();


            var count = myArr.Length;
            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    myArr[i] = myArr[i] + myArr[i + 1];

                }
                
                count--;
            }

            Console.WriteLine(myArr[0]);
            
        }
    }
}

