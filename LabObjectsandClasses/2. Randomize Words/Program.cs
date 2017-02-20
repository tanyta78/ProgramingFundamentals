using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random generator = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                int index = generator.Next(0, input.Length);
                input[i] = input[index];
                input[index] = current;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
