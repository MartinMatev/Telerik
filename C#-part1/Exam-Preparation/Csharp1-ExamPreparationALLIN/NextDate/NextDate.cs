using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            //CultureInfo culture = CultureInfo.InvariantCulture;
            //string day = Console.ReadLine();
            //string month = Console.ReadLine();
            //string year = Console.ReadLine();
            //string inputDate = day + "." + month + "." + year;
            //string format = "d.M.yyyy";

            //DateTime currentDate = DateTime.ParseExact(inputDate, format, culture);
            //DateTime tomorrowDate = currentDate.AddDays(1);

            //Console.WriteLine(tomorrowDate.ToString("d"));

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime currentTime = new DateTime(year, month, day);
            DateTime tomorrow = currentTime.AddDays(1);
            Console.WriteLine(tomorrow.ToString("d.M.yyyy"));
        }
    }
}
