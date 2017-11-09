namespace _1.Convert_from_base_10_to_base_N
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
            BigInteger baseNumber = BigInteger.Parse(input[0]);
            BigInteger numberToConvert = BigInteger.Parse(input[1]);
            string result = string.Empty;
            while (numberToConvert != 0)
            {
                result = numberToConvert % baseNumber + result;
                numberToConvert = numberToConvert / baseNumber;
            }
            Console.WriteLine(result);
        }
    }
}
