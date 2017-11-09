namespace _1.Count_Working_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    class CountWorkingDays
    {
        static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            var startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            List<DateTime> holydays = new List<DateTime>();
            holydays.Add(new DateTime(2016, 01, 01));
            holydays.Add(new DateTime(2016, 03, 03));
            holydays.Add(new DateTime(2016, 05, 01));
            holydays.Add(new DateTime(2016, 05, 06));
            holydays.Add(new DateTime(2016, 05, 24));
            holydays.Add(new DateTime(2016, 09, 06));
            holydays.Add(new DateTime(2016, 09, 22));
            holydays.Add(new DateTime(2016, 11, 01));
            holydays.Add(new DateTime(2016, 12, 26));
            holydays.Add(new DateTime(2016, 12, 25));
            holydays.Add(new DateTime(2016, 12, 24));

            int workingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime newDate = new DateTime(2016, currentDate.Month, currentDate.Day);
                if (!holydays.Contains(newDate) && currentDate.DayOfWeek != DayOfWeek.Sunday && currentDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}