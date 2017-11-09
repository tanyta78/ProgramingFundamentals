using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
