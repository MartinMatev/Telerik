using System;
using System.Globalization;

/*
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
 * preliminary as array.
 */
class WorkDays
{
    private static DateTime today;
    private static DateTime lastDate;
    private static int allDays;
    static void Main()
    {
        lastDate = GetLastDate();
        CalculateWorkDays(lastDate);
    }

    private static void CalculateWorkDays(DateTime lastDate)
    {
        DateTime[] holidays = 
        {
            new DateTime(2015, 1, 1),
            new DateTime(2015, 1, 2),
            new DateTime(2015, 3, 2),
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 9, 21),
            new DateTime(2015, 9, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };

        DateTime[] workingOutDays = 
        {
            new DateTime(2015, 1, 24),
            new DateTime(2015, 3, 21),
            new DateTime(2015, 9, 12),
            new DateTime(2015, 12, 12)
        };

        today = DateTime.Today;
        allDays = (lastDate - today).Days;

        while (lastDate >= today)
        {
            if ((today.DayOfWeek == DayOfWeek.Saturday) || today.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int i = 0; i < workingOutDays.Length; i++)
                {
                    if (today == workingOutDays[i])
                    {
                        allDays++;
                    }
                }
                allDays--;
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today == holidays[i])
                    {
                        allDays--;
                    }
                }

                for (int j = 0; j < workingOutDays.Length; j++)
                {
                    if (today == workingOutDays[j])
                    {
                        allDays++;
                    }
                }
            }
            today = today.AddDays(1);
        }
        PrintResult();
    }

    private static void PrintResult()
    {
        Console.WriteLine("There are {0} working days in that period!", allDays);
    }

    private static DateTime GetLastDate()
    {
        string format = "d/M/yyyy";
        Console.Write("Enter the final date (format: d/M/yyyy): ");
        return DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
    }
}