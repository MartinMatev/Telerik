using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanPie
{
    class AmericanPie
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            long nominator = a * d + c * b;
            long denominator = b * d;

            decimal sum = (decimal)nominator / denominator;

            if (sum >= 1)
            {
                Console.WriteLine((long)sum);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
            else
            {
                Console.WriteLine("{0:F20}", sum);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
        }
    }
}
