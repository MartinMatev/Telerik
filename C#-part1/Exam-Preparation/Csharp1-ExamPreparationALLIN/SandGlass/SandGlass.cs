using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            int outerDots = 0;
            int innerStars = n;

            // Building the top
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, outerDots));
                Console.Write(new string(star, innerStars));
                Console.Write(new string(dot, outerDots));

                Console.WriteLine();
                outerDots++;
                innerStars -= 2;
            }

            // Building the middle
            Console.Write(new string(dot, n / 2));
            Console.Write(star);
            Console.WriteLine(new string(dot, n / 2));

            // Building the bottom
            outerDots--;
            innerStars += 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dot, outerDots > 0 ? outerDots : 0));
                Console.Write(new string(star, innerStars));
                Console.Write(new string(dot, outerDots > 0 ? outerDots : 0));

                Console.WriteLine();
                outerDots--;
                innerStars += 2;
            }
        }
    }
}
