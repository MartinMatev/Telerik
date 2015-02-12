using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 6 + ((n - 3) / 2) * 3;
            int width = 2 * n + 1;
            char dot = '.';
            char star = '*';
            
            // Top of diamond (always the same)
            Console.Write(new string(dot, (n + 1) / 2));
            Console.Write(new string(star, n));
            Console.WriteLine(new string(dot, (n + 1) / 2));

            // Top half
            int topOuterDotCounter = n / 2;
            int topInnerDotCounter = n / 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, topOuterDotCounter));
                Console.Write(star);
                Console.Write(new string(dot, topInnerDotCounter));
                Console.Write(star);
                Console.Write(new string(dot, topInnerDotCounter));
                Console.Write(star);
                Console.Write(new string(dot, topOuterDotCounter));

                topOuterDotCounter--;
                topInnerDotCounter++;
                Console.WriteLine();
            }
            
            // Middle part
            Console.WriteLine(new string(star, width));

            // Bottom half
            int bottomInnerDotCounter = n - 2;

            for (int i = 1; i < n - 1
                ; i++)
            {
                Console.Write(new string(dot, i));
                Console.Write(star);
                Console.Write(new string(dot, bottomInnerDotCounter));
                Console.Write(star);
                Console.Write(new string(dot, bottomInnerDotCounter));
                Console.Write(star);
                Console.Write(new string(dot, i));

                bottomInnerDotCounter--;
                Console.WriteLine();
            }

            // Bottom of Diamond (always the same)
            Console.Write(new string(dot, n - 1));
            Console.Write(new string(star, 3));
            Console.WriteLine(new string(dot, n - 1));
            Console.Write(new string(dot, n));
            Console.Write(star);
            Console.WriteLine(new string(dot, n));
        }
    }
}
