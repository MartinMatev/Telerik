using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = (2 * n) - 3;
            char dot = '.';
            char star = '*';
            int outerCounter = n - 2;
            int innerCounter = 1;
            
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(dot, outerCounter > 0 ? outerCounter : 0));
                Console.Write(new string(star, innerCounter));
                Console.Write(new string(dot, outerCounter > 0 ? outerCounter : 0));

                Console.WriteLine();
                outerCounter--;
                innerCounter += 2;
                if (i + 2 == height)
                {
                    outerCounter = n - 2;
                    innerCounter = 1;
                }
            }
        }
    }
}
