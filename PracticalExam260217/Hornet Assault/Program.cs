using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	On the first line of input you will receive a sequence of integers, separated by spaces – the beehives.
            //•	On the second line of input you will receive a sequence of integers, separated by spaces – the hornets.

            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            long hornetPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
                 
            { 
                if (hornetPower>beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] = beehives[i] - hornetPower;
                    hornets.RemoveAt(0);
                    if (hornets.Count==0)
                    {
                        break;
                    }
                    hornetPower = hornets.Sum();
                }
            }



            if (beehives.Sum()==0)
            {
                Console.WriteLine(string.Join(" ",hornets.Where(x => x != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x != 0)));
            }
        
        

        }
    }
}
