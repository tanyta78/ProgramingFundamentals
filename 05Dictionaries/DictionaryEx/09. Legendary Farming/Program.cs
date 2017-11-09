namespace _9.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            SortedDictionary<string, long> notKeyMaterials = new SortedDictionary<string, long>();
            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            bool getLegendaryItem = false;
            while (!getLegendaryItem)
            {
                List<string> inputLine = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < inputLine.Count; i += 2)
                {
                    long quantity = long.Parse(inputLine[i]);
                    string material = inputLine[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            GetLegendaryItem(material);
                            keyMaterials[material] -= 250;
                            getLegendaryItem = true;
                            break;
                        }
                    }
                    else
                    {
                        if (notKeyMaterials.ContainsKey(material))
                        {
                            notKeyMaterials[material] += quantity;
                        }
                        else
                        {
                            notKeyMaterials.Add(material, quantity);
                        }
                    }

                }
            }

            keyMaterials = keyMaterials.OrderBy(x => x.Key).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in keyMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in notKeyMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static void GetLegendaryItem(string material)
        {
            switch (material)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }


        }
    }
}
