namespace _7.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        /// <summary>
        /// /Write a class Sale holding the following data: town, product, price, quantity. Read a list of sales and calculate and print the total sales by town as shown in the output. Order alphabetically the towns in the output.
        /// </summary>
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesReport = new SortedDictionary<string, decimal>();
            for (int i = 0; i < numberOfSales; i++)
            {
                Sale currentSale = ReadSale();
                if (!salesReport.ContainsKey(currentSale.Town))
                {
                    salesReport.Add(currentSale.Town, currentSale.Price * currentSale.Quantity);
                }
                else
                {
                    salesReport[currentSale.Town] += currentSale.Price * currentSale.Quantity;
                }
            }
            foreach (var town in salesReport)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        private static Sale ReadSale()
        {
            Sale csale = new Sale();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            csale.Town = input[0];
            csale.Product = input[1];
            csale.Price = decimal.Parse(input[2]);
            csale.Quantity = decimal.Parse(input[3]);
            return csale;
        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
    }
}
