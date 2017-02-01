namespace _3.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();
            int k = arr.Count() / 2;
            List<int> firstrow = arr.Skip(k / 2).Take(k).ToList();

            arr.RemoveRange(k / 2, k);
            List<int> leftpart = arr.Take(k / 2).Reverse().ToList();
            List<int> rigthpart = arr.Skip(k / 2).Take(k / 2).Reverse().ToList();
            List<int> secondrow = leftpart.Concat(rigthpart).ToList();
            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = firstrow[i] + secondrow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
