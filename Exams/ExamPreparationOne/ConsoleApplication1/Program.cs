using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// •	The first line will be the time Sino leaves SoftUni in the following format: HH:mm:ss
        ///•	The second line will contain the number of steps that he needs to walk to his home.This number will be an integer in range[0…2, 147, 483, 647]
        ///	On the final line you will receive the time in seconds for each step.This number will be an integer in range[0…2, 147, 483, 647]
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            DateTime timeLeave = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss",CultureInfo.InvariantCulture);
            double steps = double.Parse(Console.ReadLine());
            double secForStep = double.Parse(Console.ReadLine());
            double secNeeded = steps * secForStep;
            DateTime result = timeLeave.AddSeconds((double)secNeeded);
            Console.WriteLine($"Time Arrival: {result.Hour:00}:{result.Minute:00}:{result.Second:00}");
        }
        static void Second()
        {
            DateTime leaves = DateTime.Parse(Console.ReadLine());

            double steps = double.Parse(Console.ReadLine()) % 86400;//steps in seconds
                                                                    //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход
            double timeInSeconds = double.Parse(Console.ReadLine()) % 86400;//time in seconds for each step

            double allTime = steps * timeInSeconds / 3600;//in seconds
            Console.WriteLine("Time Arrival: " + (leaves.AddHours(allTime)).TimeOfDay);
        }
    }
}
