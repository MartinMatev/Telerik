using System;
using System.Globalization;

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
class DateInBulgarian
{
    static void Main()
    {
        // 13.03.2015 18:37:59
        DateTime inputDate = GetInput();
        inputDate = inputDate.AddHours(6.5);

        Console.WriteLine("{0} {1}", inputDate.ToString("dddd", new CultureInfo("bg-BG")), inputDate);
    }

    private static DateTime GetInput()
    {
        string format = "d.M.yyyy HH:mm:ss";
        Console.WriteLine("Type in the date in format:[day.month.year hour:minute:second]");
        Console.Write(">> ");
        return DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
    }
}
