using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            if (n >= 3 && n <= 27)
            {
                int counter = 0;
                int width = (2 * n) + 1;
                int height = 6 + ((n - 3) / 2) * 3;

                int topPart = (6 + ((n - 3) / 2) * 2) / 2;
                // Top part
                for (int row = 0; row < topPart; row++)
                {
                    if (row > 0 && row < topPart)
                    {
                        Console.Write('H');
                    }
                    for (int col = 0; col < width; col++)
                    {
                        if (row == topPart - 1)
                        {
                            Console.Write('*');
                        }
                        else if (n + 2 * col == width)
                        {
                            while (n > 0)
                            {
                                n--;
                                col++;
                                Console.Write('*');
                            }
                            Console.Write('.');
                        }
                        else if ((n + 2 * counter) - 1 == width)
                        {

                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
