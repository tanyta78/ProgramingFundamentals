using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingsFlaps = int.Parse(Console.ReadLine());
            double distanceMeterPer1000wings = double.Parse(Console.ReadLine());

            int enduranceWingsFlapsForStop = int.Parse(Console.ReadLine());
            // 100 wing per second
            //5 sec rest after endurance

            double distanceInmeters = (wingsFlaps/1000)*distanceMeterPer1000wings;
                double timeFordistanceInSec =(wingsFlaps/100)+(wingsFlaps/enduranceWingsFlapsForStop)*5;


            Console.WriteLine($"{distanceInmeters:f2} m.");
            Console.WriteLine($"{timeFordistanceInSec} s.");

        }
    }
}
