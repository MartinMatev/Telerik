using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class TwoFourEight
    {
        static void Main(string[] args)
        {
            ulong A = ulong.Parse(Console.ReadLine());
            ulong B = ulong.Parse(Console.ReadLine());
            ulong C = ulong.Parse(Console.ReadLine());
            ulong R = 0;

            if (B == 2)
            {
                R = A % C;
            }
            else if (B == 4)
            {
                R = A + C;
            }
            else if (B == 8)
            {
                R = A * C;
            }

            ulong temp = 0;
            if (R % 4 == 0)
            {
                temp = R / 4;
                Console.WriteLine(temp);
                Console.WriteLine(R);
            }
            else if (R % 4 != 0)
            {
                temp = R % 4;
                Console.WriteLine(temp);
                Console.WriteLine(R);
            }
        }
    }
}
