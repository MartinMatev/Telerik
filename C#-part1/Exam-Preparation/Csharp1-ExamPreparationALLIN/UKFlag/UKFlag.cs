using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKFlag
{
    class UKFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char slashNormal = '/';
            char slashStraight = '|';
            char slashEscape = '\\';

            int innerDots =  (n / 2) - 1;
            int outerDots = 0;
            // Top Part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, i));
                Console.Write(slashEscape);
                Console.Write(new string(dot, innerDots));
                Console.Write(slashStraight);
                Console.Write(new string(dot, innerDots));
                Console.Write(slashNormal);
                Console.Write(new string(dot, i));

                Console.WriteLine();
                innerDots--;
                outerDots = i;
            }
            
            // Middle
            Console.Write(new string('-', n / 2));
            Console.Write('*');
            Console.WriteLine(new string('-', n / 2));

            // Bottom Part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, outerDots));
                Console.Write(slashNormal);
                Console.Write(new string(dot, i));
                Console.Write(slashStraight);
                Console.Write(new string(dot, i));
                Console.Write(slashEscape);
                Console.Write(new string(dot, outerDots));

                Console.WriteLine();
                outerDots--;
            }
        }
    }
}
