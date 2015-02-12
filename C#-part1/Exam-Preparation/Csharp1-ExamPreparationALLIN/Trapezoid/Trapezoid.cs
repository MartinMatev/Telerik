using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n + 1;
            char dot = '.';
            char star = '*';

            // Print the top line
            Console.Write(new string(dot, n));
            Console.WriteLine(new string(star, n));

            // Print the body
            int outerDots = n - 1;
            int innerDots = n - 1;
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write(new string(dot, outerDots));
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);

                Console.WriteLine();
                outerDots--;
                innerDots++;
            }

            // Print the bottom line
            Console.WriteLine(new string(star, width));
        }
    }
}
