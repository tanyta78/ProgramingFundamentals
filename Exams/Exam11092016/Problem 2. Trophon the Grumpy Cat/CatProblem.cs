using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//02. Trophon the Grumpy Cat
namespace TrophonTheGrumpyCat
{
    class TrophonTheGrumpyCat
    {
        static void Main()
        {
            List<int> priceRatings = Console.ReadLine().Split().Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            int elementPrice = priceRatings[entryPoint];
            string itemsCat = Console.ReadLine();
            string itemsType = Console.ReadLine();

            IEnumerable<int> leftItems = Enumerable.Empty<int>();
            IEnumerable<int> rightItems = Enumerable.Empty<int>();
            int leftSum = 0;
            int rightSum = 0;

            if (itemsCat == "cheap")
            {
                leftItems = priceRatings.Take(entryPoint).Where(x => x < elementPrice);
                rightItems = priceRatings.Skip(entryPoint + 1).Where(x => x < elementPrice);
            }
            else//Expensive
            {
                leftItems = priceRatings.Take(entryPoint).Where(x => x >= elementPrice);
                rightItems = priceRatings.Skip(entryPoint + 1).Where(x => x >= elementPrice);
            }

            if (itemsType == "positive")
            {
                leftItems = leftItems.Where(x => x > 0);
                rightItems = rightItems.Where(x => x > 0);
            }
            else if (itemsType == "negative")
            {
                leftItems = leftItems.Where(x => x < 0);
                rightItems = rightItems.Where(x => x < 0);
            }

            leftSum = leftItems.Sum();
            rightSum = rightItems.Sum();

            if (leftSum > rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else if (leftSum < rightSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }
        }
    }
}