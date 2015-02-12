using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_6_9
{
    class ThreeSixNine
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r = 0;

            if (b == 3)
            {
                r = a + c;
            }
            if (b == 6)
            {
                r = a * c;
            }
            if (b == 9)
            {
                r = a % c;
            }

            long remainder = r % 3;
            if (remainder == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(remainder);
                Console.WriteLine(r);
            }
        }
    }
}
