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
    private static int workDays;
    static void Main()
    {
        lastDate = GetLastDate();
        CalculateWorkDays(lastDate);
    }

    private static void CalculateWorkDays(DateTime lastDate)
    {
        // Making an array of type DateTime to store the official holidays of 2015
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
        // And an array storing the working out days (дни за отработване демек)
        DateTime[] workingOutDays = 
        {
            new DateTime(2015, 1, 24),
            new DateTime(2015, 3, 21),
            new DateTime(2015, 9, 12),
            new DateTime(2015, 12, 12)
        };

        today = DateTime.Today;
        workDays = (lastDate - today).Days;

        while (lastDate >= today)
        {
            // Check if the current day is either saturday or sunday
            if ((today.DayOfWeek == DayOfWeek.Saturday) || today.DayOfWeek == DayOfWeek.Sunday)
            {
                // If it is, check if its not a day for отработване
                for (int i = 0; i < workingOutDays.Length; i++)
                {
                    // If by chance it is, go be sad at work and add a day towards the work days count
                    if (today == workingOutDays[i])
                    {
                        workDays++;
                    }
                }
                workDays--;
            }
            else
            {
                // If the current day is between Monday - Friday, check if it's not an official holiday,
                // by looping through all of the data of the holiday array
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today == holidays[i])
                    {
                        workDays--;
                    }
                }

                for (int j = 0; j < workingOutDays.Length; j++)
                {
                    if (today == workingOutDays[j])
                    {
                        workDays++;
                    }
                }
            }
            // Change the current day with the next one, using mystical Godly powers
            today = today.AddDays(1);
        }
        PrintResult();
    }

    private static void PrintResult()
    {
        Console.WriteLine("There are {0} working days in that period!", workDays);
    }

    private static DateTime GetLastDate()
    {
        string format = "d/M/yyyy";
        Console.Write("Enter the final date (format: d/M/yyyy): ");
        return DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
    }
}