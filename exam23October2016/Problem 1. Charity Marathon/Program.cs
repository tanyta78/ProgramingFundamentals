using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Charity_Marathon
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int maratonDays = int.Parse(Console.ReadLine());//2
            int runners = int.Parse(Console.ReadLine());//50
            int averageNumberOfLabs = int.Parse(Console.ReadLine());//2
            int lengthOfTrack = int.Parse(Console.ReadLine());//400
            int capacityOfTrack = int.Parse(Console.ReadLine());//30
            double moneyPerKm = double.Parse(Console.ReadLine());//3
            //50*2*400/1000*3

            long maxRunnersForAllDays = capacityOfTrack * maratonDays;//30*2
            long runnersForCalc = 0;
            if (maxRunnersForAllDays>runners)
            {
                runnersForCalc = runners;
            }else
            {
                runnersForCalc = maxRunnersForAllDays;
            }

            double kmRunned =(double)runnersForCalc * averageNumberOfLabs * lengthOfTrack / 1000;
            double moneyReised = moneyPerKm * kmRunned;
            Console.WriteLine($"Money raised: {moneyReised:f2}");
        }
    }
}
