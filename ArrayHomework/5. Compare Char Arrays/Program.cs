namespace _5.Compare_Char_Arrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int minlen = Math.Min(len1, len2);

            for (int i = 0; i < minlen; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                        break;
                    }
                }
                else if (i == minlen - 1)
                {
                    if (len1 > len2)
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                    }
                    else
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                    }
                }
            }
        }
    }
}
