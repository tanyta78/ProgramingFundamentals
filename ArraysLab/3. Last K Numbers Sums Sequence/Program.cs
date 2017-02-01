using System;
class LAstKNumbers
{
    static void Main(string[] args)
    {
        int numberOfElements = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] nums = new long[numberOfElements];
        nums[0] = 1;

        for (int index = 1; index < numberOfElements; index++)
        {
            long sum = 0;
            for (int previosindex = index - k; previosindex <= index - 1; previosindex++)
            {
                if (previosindex >= 0)
                {
                    sum += nums[previosindex];
                    nums[index] = sum;
                }
                   
            }
               
        }

        Console.WriteLine(string.Join(" ", nums));
    }

}

