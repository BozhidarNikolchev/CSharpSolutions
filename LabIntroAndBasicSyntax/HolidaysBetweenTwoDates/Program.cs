using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        try
        {
            string[] acceptableFormats = {
                "dd.MM.yyyy", "d.M.yyyy", "d.MM.yyyy", "dd.M.yyyy",
                "dd-MM-yyyy", "d-M-yyyy", "d-MM-yyyy", "dd-M-yyyy",
                "yyyy-MM-dd", "yyyy.MM.dd"
            };

            var startDate = ParseDate("Enter the start date:", acceptableFormats);
            var endDate = ParseDate("Enter the end date:", acceptableFormats);

            if (endDate < startDate)
            {
                Console.WriteLine(0);
                Console.WriteLine("The second date is before the first. No dates in the range.");
                return;
            }

            List<DateTime> holidays = new List<DateTime>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidays.Add(date);
                }
            }

            int holidaysCount = holidays.Count;
            Console.WriteLine(holidaysCount);

            if (holidaysCount == 0)
            {
                Console.WriteLine("There are no non-working days (Saturday/Sunday) in this period.");
            }
            else if (holidaysCount == 1)
            {
                var onlyDay = holidays[0];
                Console.WriteLine($"Only 1 non-working day in the specified period: {onlyDay.Day}.{onlyDay.Month:D2}.{onlyDay.Year} ({onlyDay:dddd})");
            }
            else
            {
                // Check for grouping by consecutive weekends
                var grouped = GroupByConsecutiveWeekends(holidays);
                if (grouped.Count == 1)
                {
                    // Just list all holidays
                    Console.WriteLine($"There are {holidaysCount} non-working days (Saturday / Sunday) in this period: {string.Join(", ", holidays.Select(d => d.ToString("d-MMM-yyyy", CultureInfo.InvariantCulture)))}");
                }
                else
                {
                    Console.WriteLine($"{grouped.Count} {(grouped.Count == 1 ? "weekend" : "weekends")}:");
                    foreach (var group in grouped)
                    {
                        Console.WriteLine("· " + string.Join(" and ", group.Select(d => d.ToString("d.MM.yyyy", CultureInfo.InvariantCulture))));
                    }
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format. Please, use a date like 01.05.2016, 1.5.2016, 2016-05-01, etc.");
        }
    }

    static DateTime ParseDate(string prompt, string[] formats)
    {
        Console.WriteLine(prompt);
        return DateTime.ParseExact(Console.ReadLine(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
    }

    // Groups holidays into consecutive weekends (Sat+Sun)
    static List<List<DateTime>> GroupByConsecutiveWeekends(List<DateTime> holidays)
    {
        var result = new List<List<DateTime>>();
        var tempGroup = new List<DateTime>();

        for (int i = 0; i < holidays.Count; i++)
        {
            if (tempGroup.Count == 0)
            {
                tempGroup.Add(holidays[i]);
            }
            else
            {
                if ((holidays[i] - tempGroup.Last()).Days == 1)
                {
                    tempGroup.Add(holidays[i]);
                }
                else
                {
                    result.Add(new List<DateTime>(tempGroup));
                    tempGroup.Clear();
                    tempGroup.Add(holidays[i]);
                }
            }
        }
        if (tempGroup.Count > 0)
            result.Add(tempGroup);

        return result;
    }
}