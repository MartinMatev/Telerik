using System;

// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.
class LeapYear
{
    static void Main()
    {
        DateTime year = GetYear();
        Console.WriteLine("The year {0} is {1}", year.Year, LeapYearCheck(year));       
    }

    private static string LeapYearCheck(DateTime year)
    {
        if (DateTime.IsLeapYear(year.Year))
        {
            return "leap.";
        }
        return "not leap.";
    }

    private static DateTime GetYear()
    {
        Console.Write("Enter the year you want checked: ");
        string format = "yyyy";
        return DateTime.ParseExact(Console.ReadLine(), format, System.Globalization.CultureInfo.InvariantCulture);
    }
}