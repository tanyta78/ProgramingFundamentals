namespace _2.Convert_from_base_N_to_base_10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int baseNumber = int.Parse(input[0]);
            string numberToConvert = input[1];
            BigInteger result = 0;
            int len = numberToConvert.Length;
            for (int i = 0; i < len; i++)
            {
                int currentDigit = int.Parse(numberToConvert[len - 1 - i].ToString());
                result += currentDigit * BigInteger.Pow(baseNumber, i);
            }
            Console.WriteLine(result);
        }
    }
}