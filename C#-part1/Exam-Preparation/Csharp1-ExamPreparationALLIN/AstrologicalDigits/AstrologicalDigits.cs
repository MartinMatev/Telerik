using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim('-').Replace(".", "");
            BigInteger number = BigInteger.Parse(input);
            BigInteger numberCopy = number;
            BigInteger sum = 0;

            while (true)
            {
                sum = 0;
                for (BigInteger i = number; i > 0; i /= 10)
                {                 
                    sum += i % 10;
                }

                if (sum <= 9)
                {
                    break;
                }
                else
                {
                    number = sum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
