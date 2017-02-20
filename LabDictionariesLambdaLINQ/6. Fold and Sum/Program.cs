using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            List<int> inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = inputLine.Count / 4;
            var firstRowLeft = inputLine.Take(k).Reverse().ToList();
            var firstRowRigth = inputLine.Skip(3 * k).Take(k).Reverse().ToList();
            firstRowLeft.AddRange(firstRowRigth);
          
            var secondRow = inputLine.Skip(k).Take(k*2).ToList();
            var result = firstRowLeft.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
