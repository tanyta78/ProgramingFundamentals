namespace _7.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ////On each input line you’ll be given data in format: "city|country|population".There will be no redundant whitespaces anywhere in the input. Aggregate the data by country and by city and prlong it on the console. For each country, prlong its total population and on separate lines the data for each of its cities.Countries should be ordered by their total population in descending order and within each country, the cities should be ordered by the same criterion.If */*/two countries / cities have the same population, keep them in the order in which they were entered.

            List<string> input = Console.ReadLine().Split('|').ToList();

            var countryPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (!input[0].Equals("report"))
            {
                string city = input[0];
                string country = input[1];
                long population = int.Parse(input[2]);


                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, new Dictionary<string, long>());
                }

                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country].Add(city, population);
                }
                else
                {
                    countryPopulation[country][city] += population;
                }


                input = Console.ReadLine().Split('|').ToList();
            }

            foreach (var state in countryPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}