namespace _4.Character_Multiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int len1 = input[0].Length;
            int len2 = input[1].Length;
            int result = 0;
            string toAdd = string.Empty;
            for (int i = 0; i < Math.Min(len1, len2); i++)
            {
                result += input[0][i] * input[1][i];
            }
            if (len1 > len2)
            {
                toAdd = input[0];
            }
            else if (len1 < len2)
            {
                toAdd = input[1];
            }
            for (int i = Math.Min(len1, len2); i < Math.Max(len1, len2); i++)
            {
                result += toAdd[i];
            }
            Console.WriteLine(result);
        }
    }
}