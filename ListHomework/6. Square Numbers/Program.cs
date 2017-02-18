namespace _6.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Square_Numbers
    {
        static void Main()
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();
            foreach (var number in numbersList)
            {
                if (Math.Sqrt(number)==(int)Math.Sqrt(number))
                {
                    squareNumbers.Add(number);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
