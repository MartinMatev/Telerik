using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            int totalSheetsOfpaper = n * s;
            decimal realms = (decimal)totalSheetsOfpaper / 500;
            decimal totalPrice = realms * p;
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
