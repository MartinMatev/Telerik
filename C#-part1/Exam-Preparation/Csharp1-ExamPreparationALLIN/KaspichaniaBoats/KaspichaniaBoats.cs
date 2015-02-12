using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichaniaBoats
{
    class KaspichaniaBoats
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n * 2) + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            char dot = '.';
            char star = '*';
            int size = 2;

            // Builting the head
            Console.Write(new string(dot, n));
            Console.Write(star);
            Console.WriteLine(new string(dot, n));
            Console.Write(new string(dot, n - 1));
            Console.Write(new string(star, 3));
            Console.WriteLine(new string(dot, n - 1));

            // Building the top half
            int topCounter = n - 2;

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(dot, topCounter));
                Console.Write(star);
                Console.Write(new string(dot, i + 1));
                Console.Write(star);
                Console.Write(new string(dot, i + 1));
                Console.Write(star);
                Console.Write(new string(dot, topCounter));

                Console.WriteLine();
                topCounter--;
                size++;
            }

            // Building middle part
            Console.WriteLine(new string(star, width));
            size++;

            // Building Bottom half
            int currentLength = height - size;
            int bottomCounter = n - 2;

            for (int i = 1; i < currentLength; i++)
            {
                Console.Write(new string(dot, i));
                Console.Write(star);
                Console.Write(new string(dot, bottomCounter));
                Console.Write(star);
                Console.Write(new string(dot, bottomCounter));
                Console.Write(star);
                Console.Write(new string(dot, i));

                bottomCounter--;
                Console.WriteLine();
            }

            // Building the end
            Console.Write(new string(dot, (width - n) / 2));
            Console.Write(new string(star, n));
            Console.WriteLine(new string(dot, (width - n) / 2));
        }
    }
}
