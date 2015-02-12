using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int listCount = 10;
            int digit = 0;

            for (int i = 0; i <= 10; i++)
            {
                int mask = 1 << i;
                digit = n & mask;
                if (digit == 0)
                {
                    Console.WriteLine("A{0}", listCount - i);
                }
            }
        }
    }
}
