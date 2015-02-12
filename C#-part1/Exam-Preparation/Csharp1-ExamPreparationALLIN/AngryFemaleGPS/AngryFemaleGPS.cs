using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim('-');
            long evenSum = 0;
            long oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] - '0') % 2 == 0)
                {
                    evenSum += input[i] - '0';
                }
                else
                {
                    oddSum += input[i] - '0';
                }
            }
            if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (evenSum < oddSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else
            {
                Console.WriteLine("straight {0}", evenSum);
            }
        }
    }
}
