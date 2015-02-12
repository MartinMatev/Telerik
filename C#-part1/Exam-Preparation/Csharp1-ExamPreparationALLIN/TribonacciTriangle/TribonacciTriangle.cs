using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());
            long n3 = long.Parse(Console.ReadLine());
            long lines = long.Parse(Console.ReadLine());

            for (int row = 1; row <= lines; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    if (row == 1)
                    {
                        Console.Write("{0}", n1);
                        break;
                    }
                    if (row == 2)
                    {
                        Console.Write("{0} {1}", n2, n3);
                        break;
                    }
                    long sum = n1 + n2 + n3;
                    if (col == row - 1)
                    {
                        Console.Write("{0}", sum);
                    }
                    else
                    {
                        Console.Write("{0} ", sum);
                    }
                    n1 = n2;
                    n2 = n3;
                    n3 = sum;
                }
                Console.WriteLine();
            }
        }
    }
}
