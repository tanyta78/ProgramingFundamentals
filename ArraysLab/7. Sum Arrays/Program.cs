namespace _7.Sum_Arrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ////Write a program that reads two arrays of integers and sums them. When the arrays are not of the same size, duplicate the smaller array a few times.
            int[] firstArr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            int[] secondArr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            int len1 = firstArr.Length;
            int len2 = secondArr.Length;
            int[] sumArr = new int[Math.Max(len1, len2)];

            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = firstArr[i % len1] + secondArr[i % len2];
                Console.WriteLine(sumArr[i]);
            }
        }
    }
}
