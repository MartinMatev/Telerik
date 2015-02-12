using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeaceOfCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long D = long.Parse(Console.ReadLine());

            decimal numerator = A * D + B * C;
            decimal denominator = B * D;
            decimal sumBothCities = numerator / denominator;

            if (sumBothCities >= 1)
            {
                Console.WriteLine((long)sumBothCities);
                Console.WriteLine(numerator + "/" + denominator);
            }
            else
            {
                Console.WriteLine("{0:F22}", (decimal)sumBothCities);
                Console.WriteLine(numerator + "/" + denominator);
            }
        }
    }
}
