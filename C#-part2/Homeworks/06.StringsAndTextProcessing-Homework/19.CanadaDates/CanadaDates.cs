using System;
using System.Globalization;
using System.Text.RegularExpressions;

/*
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
 */
class CanadaDates
{
    static void Main()
    {
        string text = "I was walking around 12.04.2015 when suddenly an axe bearing grizzly unicorn rushed towards 26.11.1969 . It was then I decided it's 30.7.1981 to stop doing drugs. I need help. 40.50.3999 (will not appear in output)";
        string format = "dd.MM.yyyy";

        //Finds a 2 digit number, with a space BEFORE IT, `.` after it, followed by another 2 digit number, followed by a `.` and a 4 digit number with a space after it.
        string dateTemplate = @"\b\d{2}.\d{2}.\d{4}";

        foreach (Match match in Regex.Matches(text, dateTemplate))
        {
            DateTime date;
            if (DateTime.TryParseExact(match.Value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Output: {0}", date.ToString(CultureInfo.GetCultureInfo("fr-CA").DateTimeFormat.ShortDatePattern));
            }            
        }
    }
}
