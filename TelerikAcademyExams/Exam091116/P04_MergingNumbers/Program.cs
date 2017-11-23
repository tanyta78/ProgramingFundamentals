namespace P04_MergingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
       public static void Main(string[] args)
       {
           var lines = int.Parse(Console.ReadLine());
           var mergedNums = new List<string>();
           var summedNums = new List<int>();
           var first = Console.ReadLine();

            for (int i = 1; i < lines; i++)
           {
              var second = Console.ReadLine();

               var merged = string.Concat((char)first[1],(char)second[0]);
               var summed = int.Parse(first) + int.Parse(second);
               mergedNums.Add(merged);
               summedNums.Add(summed);
               first = second;
           }

           Console.WriteLine(string.Join(" ",mergedNums));
           Console.WriteLine(string.Join(" ",summedNums));

        }
    }
}
