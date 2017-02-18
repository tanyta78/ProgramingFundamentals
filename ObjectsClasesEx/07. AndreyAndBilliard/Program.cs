namespace _7.Andrey_and_billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Andrey_and_billiard
    {
        public static void Main()
        {
            int numberProducts = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();
            for (int i = 0; i < numberProducts; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                productPrices[input[0]] = decimal.Parse(input[1]);
            }
            // Console.WriteLine();
            string clientEntry = Console.ReadLine();
            List<ClientEntry> clients = new List<ClientEntry>();
            while (!clientEntry.Equals("end of clients"))
            {

                string[] orderInfo = clientEntry.Split('-', ',').ToArray();
                string name = orderInfo[0];
                string entity = orderInfo[1];
                int quantity = int.Parse(orderInfo[2]);
                if (!productPrices.ContainsKey(entity))
                {
                    clientEntry = Console.ReadLine();
                    continue;
                }
                if (clients.Any(c => c.Name == name))
                {
                    ClientEntry client = clients.First(c => c.Name == name);
                    if (!client.OrdersQuantity.ContainsKey(entity))
                    {
                        client.OrdersQuantity.Add(entity, quantity);
                    }
                    else
                    {
                        client.OrdersQuantity[entity] += quantity;
                    }
                    client.Bill += quantity * productPrices[entity];

                }
                else
                {
                    ClientEntry client = new ClientEntry();
                    client.Name = name;
                    client.OrdersQuantity = new Dictionary<string, int>();
                    client.OrdersQuantity[entity] = quantity;
                    client.Bill = quantity * productPrices[entity];
                    clients.Add(client);
                }

                clientEntry = Console.ReadLine();
            }
            //Console.WriteLine();
            decimal totalBills = 0;
            foreach (var client in clients.OrderBy(n => n.Name))
            {
                Console.WriteLine(client.Name);
                foreach (var product in client.OrdersQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:f2}");
                totalBills += client.Bill;
            }
            Console.WriteLine($"Total bill: {totalBills:f2}");
        }
    }
    public class ClientEntry
    {

        public string Name { get; set; }
        public Dictionary<string, int> OrdersQuantity { get; set; }
        public decimal Bill { get; set; }

    }





}
