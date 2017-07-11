using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03exam18032017
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Cabrio - {budget * 0.35:f2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Jeep - {budget * 0.65:f2}");
                        break;
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine("Compact class");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Cabrio - {budget * 0.45:f2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Jeep - {budget * 0.80:f2}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {budget * 0.90:f2}");
               
            }
        }
    }
}
