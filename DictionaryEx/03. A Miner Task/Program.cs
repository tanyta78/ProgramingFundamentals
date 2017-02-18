namespace _3.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            ////You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and every even – quantity. Your task is to collect the resources and print them each on a new line. 
            //// Print the resources and their quantities in format:{ resource} –> { quantity}
            //// The quantities inputs will be in the range[1 … 2 000 000 000]
            Dictionary<string, int> minerTask = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (!resource.Equals("stop"))
            {
                if (minerTask.ContainsKey(resource))
                {
                    minerTask[resource] = minerTask[resource] + int.Parse(Console.ReadLine());
                }
                else
                {
                    minerTask[resource] = int.Parse(Console.ReadLine());
                }



                resource = Console.ReadLine();
            }

            foreach (var pair in minerTask)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

        }
    }
}
