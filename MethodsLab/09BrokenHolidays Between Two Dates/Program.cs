using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(
            Console.ReadLine(),
            "d.M.yyyy",
            CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(
            Console.ReadLine(),
            "d.M.yyyy",
            CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        if (startDate > endDate)
        {
            holidaysCount = 0;
        }
        else
        {
            holidaysCount = CountHolidays(startDate, endDate);
        }
           
        Console.WriteLine(holidaysCount);
    }

    private static int CountHolidays(DateTime startDate, DateTime endDate)
    {
        var holidaysCount = 0;

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            } 
        }

        return holidaysCount;
    }
}