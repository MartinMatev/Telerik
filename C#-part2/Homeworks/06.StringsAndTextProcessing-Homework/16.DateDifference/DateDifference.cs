using System;
using System.Globalization;

/*
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 * Example:
 * 
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2006
 * Distance: 4 days
 */
class DateDifference
{
    static void Main()
    {
        try
        {
            Console.WriteLine("The date should be in format {d.m.yyyy} OR {dd.mm.yyyy} !");
            DateTime firstDate = GetDate("first");
            DateTime secondDate = GetDate("second");
            Console.WriteLine("Distance: {0}", Math.Abs((firstDate - secondDate).TotalDays));
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static DateTime GetDate(string p)
    {
        Console.Write("Enter the {0} date: ", p);
        string format = "d.M.yyyy";
        return DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
    }
}
