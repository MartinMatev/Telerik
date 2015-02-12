using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FutureAge
{
    class FutureAge
    {
        // Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter your birthdate, using the dd/mm/yyyy format: ");
                // Split the input when one of the chars are met, removes empty spaces if any, put the data into the the string array "input"
                string[] input = Console.ReadLine().Split(new char[] { '/', '.', ',', '\t', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string reformat = "dd/MM/yyyy";
                // Join the splitted data, putting "/" between the members of the "input" array, parse them to DateTime
                DateTime birthDay = DateTime.ParseExact(string.Join("/", input), reformat, System.Globalization.CultureInfo.InvariantCulture);
                // Get the total day difference between Now and your birth date, divide by the exacts number of days in 1 year, parse the double to int
                int currentAge = (int)((DateTime.Now - birthDay).TotalDays / 365.212499);

                Console.Write("Your current age is: {0}\n", currentAge);
                Console.WriteLine("Your age in ten years will be: {0}", currentAge + 10);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, use the correct format");
            }
        }
    }
}
