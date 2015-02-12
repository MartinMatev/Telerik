using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A beer time is after 1:00 PM and before 3:00 AM.
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
 * a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
 * according to the definition above or invalid time if the time cannot be parsed.
 */
namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            // Initialize a "provider" (its obligatory for the ParseExact below)
            CultureInfo provider = CultureInfo.InvariantCulture;
            // Initialize a "format" (same as above)
            string format = "h:mm tt";
            DateTime beerTimeStart = DateTime.ParseExact("01:00 PM", format, provider);
            DateTime beerTimeEnd = DateTime.ParseExact("03:00 AM", format, provider);
            Console.Write(@"Enter the time in ""h:mm tt"" format(tt = AM/PM): ");
            try
            {
                string input = Console.ReadLine();
                // Checks the input if it received the correct data format, using the "format" variable as an requirement
                DateTime timeInput = DateTime.ParseExact(input, format, provider);
                // Checks if the PM input hour is >= 01:00 PM OR if the AM input hour is < 03:00 AM
                if (timeInput >= beerTimeStart || timeInput < beerTimeEnd)
                {
                    Console.WriteLine("BEER TIME");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
