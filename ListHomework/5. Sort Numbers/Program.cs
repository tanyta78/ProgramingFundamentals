namespace _5.Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Sort_Numbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join("<= ", numbers));
        }
    }
}
