namespace P04_MixingNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var myList = new List<int>();
            var result = new List<int>();
            for (int i = 0; i < numbers; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 1; i < numbers; i++)
            {
                var mix = (myList[i - 1] % 10) * (myList[i] / 10);
                result.Add(mix);
            }

            Console.WriteLine(String.Join(" ", result));
            result.Clear();

            for (int i = 1; i < numbers; i++)
            {
                var substract = Math.Abs(myList[i - 1] - myList[i]);
                result.Add(substract);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
