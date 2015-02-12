using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterMister
{
    class EasterMister
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int widthEgg = 3 * n - 1;
            char dot = '.';
            char star = '*';
            char ribbon = '#';

            int outerDots = n + 1;
            int innerDots = n + 1;

            // Top part
            Console.Write(new string(dot, outerDots));
            Console.Write(new string(star, n - 1));
            Console.WriteLine(new string(dot, outerDots));

            // Top half
            outerDots -= 2;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(dot, outerDots >= 1 ? outerDots:1));
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);
                Console.Write(new string(dot, outerDots >= 1 ? outerDots : 1));

                Console.WriteLine();
                outerDots -= 2;
                if (outerDots < 1)
                {
                    continue;
                }
                else
                {
                    innerDots += 4;
                }
            }

            // Middle part
            StringBuilder top = new StringBuilder();
            StringBuilder bottom = new StringBuilder();

            for (int i = 0; i < widthEgg - 2; i++)
            {
                if (i % 2 == 0)
                {
                    top.Append(dot);
                    bottom.Append(ribbon);
                }
                else
                {
                    top.Append(ribbon);
                    bottom.Append(dot);
                }
            }
            // First half of ribbon
            Console.Write(dot);
            Console.Write(star);
            Console.Write(top);
            Console.Write(star);
            Console.WriteLine(dot);

            // Second half of ribbon
            Console.Write(dot);
            Console.Write(star);
            Console.Write(bottom);
            Console.Write(star);
            Console.WriteLine(dot);

            // Bottom half
            outerDots += 2;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(dot, outerDots >= 1 ? outerDots:1));
                Console.Write(star);
                Console.Write(new string(dot, innerDots));
                Console.Write(star);
                Console.Write(new string(dot, outerDots >= 1 ? outerDots : 1));

                Console.WriteLine();
                outerDots += 2;
                if (outerDots <= 1)
                {
                    continue;
                }
                else
                {
                    innerDots -= 4;
                }
            }

            // Bottom part
            Console.Write(new string(dot, outerDots));
            Console.Write(new string(star, n - 1));
            Console.WriteLine(new string(dot, outerDots));
        }
    }
}
