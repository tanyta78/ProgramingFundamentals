namespace SecretNumSystem
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
       public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = (BigInteger)1;

            foreach (var number in numbers)
            {
                var octNumberString = number
                    .Replace("haralampi", "5")
                    .Replace("hristofor", "3")
                    .Replace("vladimir", "7")
                    .Replace("hristo", "0")
                    .Replace("pesho", "2")
                    .Replace("tosho", "1")
                    .Replace("vlad", "4")
                    .Replace("zoro", "6");

                result *= new BigInteger(Convert.ToInt64(octNumberString, 8));
            }

            Console.WriteLine(result);
        }
    }
}
