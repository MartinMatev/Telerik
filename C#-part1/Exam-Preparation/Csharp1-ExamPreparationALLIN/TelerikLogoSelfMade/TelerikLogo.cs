using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikLogoSelfMade
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Z = (X / 2) + 1;
            int width = (X + X) + 2 * Z - 3;
            char dot = '.';
            char star = '*';

            int outerDots = X / 2;
            int innerDots = width - 2 * (Z);

            // Top part (always the same)
            Console.Write(new string(dot, outerDots));
            Console.Write(star);
            Console.Write(new string(dot, innerDots));
            Console.Write(star);
            Console.WriteLine(new string(dot, outerDots));
            innerDots -= 2;

            int tempCounter = X;
            int firstHornDots = (X / 2) - 1;
            int afterHornDots = 1;
            for (int i = 1; i < X - 1; i++)
            {
                if (i <= X / 2)
                {
                    Console.Write(new string(dot, firstHornDots));
                    Console.Write(star);
                    Console.Write(new string(dot, afterHornDots));
                }
                else
                {
                    Console.Write(new string(dot, outerDots + 1));
                }
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);
                if (i <= X / 2)
                {
                    Console.Write(new string(dot, afterHornDots));
                    Console.Write(star);
                    Console.Write(new string(dot, firstHornDots));
                }
                else 
                {
                    Console.Write(new string(dot, outerDots + 1));
                }                

                Console.WriteLine();
                outerDots++;
                innerDots -= 2;
                afterHornDots += 2;
                firstHornDots--;
            }

            // Middle part
            outerDots++;
            Console.Write(new string(dot, outerDots));
            Console.Write(star);
            Console.WriteLine(new string(dot, outerDots));

            // Below middle part
            innerDots = 1;
            for (int i = 0; i < X - 1; i++)
            {
                outerDots--;
                Console.Write(new string(dot, outerDots));
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);
                Console.Write(new string(dot, outerDots));

                Console.WriteLine();
                innerDots += 2;
            }

            // Lower part
            innerDots -= 2;
            for (int i = 0; i < X - 2; i++)
            {
                innerDots -= 2;
                outerDots++;
                Console.Write(new string(dot, outerDots));
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);
                Console.Write(new string(dot, outerDots));

                Console.WriteLine();
            }

            // Bottom part
            outerDots++;
            Console.Write(new string(dot, outerDots));
            Console.Write(star);
            Console.WriteLine(new string(dot, outerDots));
        }
    }
}
