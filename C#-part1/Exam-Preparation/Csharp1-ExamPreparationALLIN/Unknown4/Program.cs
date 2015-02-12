using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int widthCube = (2 * n) - 1;
            int height = n;
            int depth = n;
            char colon = ':';
            char slash = '/';
            char x = 'X';
            char blank = ' ';

            int outerBlanks = widthCube - n;
            int xCount = 0;
            // Top part
            Console.Write(new string(blank, outerBlanks));
            Console.WriteLine(new string(colon, n));

            // Top half
            outerBlanks--;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(blank, outerBlanks));
                Console.Write(colon);
                Console.Write(new string(slash, n - 2));
                Console.Write(colon);
                Console.Write(new string(x, xCount));
                Console.Write(colon);

                Console.WriteLine();
                outerBlanks--;
                xCount++;
            }

            // Middle part
            Console.Write(new string(colon, n));
            Console.Write(new string(x, xCount));
            Console.WriteLine(colon);

            // Bottom half
            xCount--;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(colon);
                Console.Write(new string(blank, n - 2));
                Console.Write(colon);
                Console.Write(new string(x, xCount >= 0 ? xCount : 0));
                Console.Write(colon);
                Console.Write(new string(blank, outerBlanks));

                Console.WriteLine();
                xCount--;
                outerBlanks++;
            }

            // Bottom part
            Console.Write(new string(colon, n));
            Console.WriteLine(new string(blank, n - 1));
        }
    }
}
