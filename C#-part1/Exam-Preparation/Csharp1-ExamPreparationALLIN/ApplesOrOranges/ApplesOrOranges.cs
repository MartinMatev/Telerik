using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesOrOranges
{
    class ApplesOrOranges
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim('-');
            int oddSum = 0;
            int evenSum = 0;

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
                Console.WriteLine("apples {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("oranges {0}", oddSum);
            }
            else
            {
                Console.WriteLine("both {0}", evenSum);
            }
        }
    }
}
