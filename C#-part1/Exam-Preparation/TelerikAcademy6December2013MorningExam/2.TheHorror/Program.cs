using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    int digit = (int)Char.GetNumericValue(input[i]);
                    if (i % 2 == 0)
                    {
                        sum += digit;
                        count++;
                    }
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
