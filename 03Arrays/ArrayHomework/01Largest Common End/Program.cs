using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Read two arrays of words and find the length of the largest common end (left or right).
            string[] arr1 = Console.ReadLine()
                                .Split(' ')
                                .ToArray();
            string[] arr2 = Console.ReadLine()
                                .Split(' ')
                                .ToArray();
            int minLenght = Math.Min(arr1.Length, arr2.Length);
            int maxLenght = Math.Max(arr1.Length, arr2.Length);
            int largesendLeft = 0;
            int largesendRigth = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    largesendLeft++;
                }
            }

            for (int i = 0; i < minLenght; i++)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    largesendRigth++;
                }
            }

            Console.WriteLine(Math.Max(largesendLeft, largesendRigth));
        }
    }
}
