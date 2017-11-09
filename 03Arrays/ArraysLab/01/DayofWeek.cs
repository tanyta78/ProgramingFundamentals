namespace _01DayofWeek
{
    using System;

    public class DayofWeek
    {
        public static void Main(string[] args)
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

            if (input > 0 && input < 8)
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
