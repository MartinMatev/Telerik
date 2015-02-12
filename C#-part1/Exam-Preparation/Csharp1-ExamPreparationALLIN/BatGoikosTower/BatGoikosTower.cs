using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikosTower
{
    class BatGoikosTower
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = height * 2;
            char dot = '.';
            char line = '-';
            char normalSlash = '/';
            char escapeSlash = '\\';
            int outsideCounter = n - 1;
            int gredaCounter = -2;


            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i <= gredaCounter; i++)
                {
                    Console.Write(new string(dot, outsideCounter));
                    Console.Write(normalSlash);
                    Console.Write(new string(dot, row));
                    Console.Write(new string(dot, row));
                    Console.Write(escapeSlash);
                    Console.Write(new string(dot, outsideCounter));

                    Console.WriteLine();
                    outsideCounter--;
                    row++;

                    if (row == n)
                    {
                        return;
                    }
                }


                Console.Write(new string(dot, outsideCounter));
                Console.Write(normalSlash);
                Console.Write(new string(line, row));
                Console.Write(new string(line, row));
                Console.Write(escapeSlash);
                Console.Write(new string(dot, outsideCounter));

                Console.WriteLine();
                outsideCounter--;
                gredaCounter++;
            }
        }
    }
}
