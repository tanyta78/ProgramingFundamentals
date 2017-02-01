namespace _02Rotate_and_Sum
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            int[] result = new int[nums.Length];
            for (int i = 0; i < n; i++)
            {
                RotateNum(nums);
                ResultSum(result, nums);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static void RotateNum(int[] nums)
        {
            var value = nums[nums.Length - 1];
            for (int site = nums.Length - 1; site > 0; site--)
            {
                nums[site] = nums[site - 1];
            }

            nums[0] = value;
            return;
        }

        public static void ResultSum(int[] result, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = result[i] + nums[i];
            }
        }
    }
}