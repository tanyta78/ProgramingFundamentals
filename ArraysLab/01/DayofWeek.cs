using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DayofWeek
{
    class DayofWeek
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[]
            {
                
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int input = int.Parse(Console.ReadLine());

            if (input>0 && input<8)
            {
                Console.WriteLine(weekDays[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
          
        }
    }
}
