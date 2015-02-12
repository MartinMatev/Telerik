using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            ///*
            // *...
            // .*..
            // ..*.
            // ...* 
            // */ 
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        // Kogato reda i kolonata suvpadat slaga zvezda
            //        if (i == j) Console.Write('*');
            //        else Console.Write('.');
            //    }
            //    Console.WriteLine();
            //}
            ///*
            // ..*.   3 red (n - 1 red)
            // .*..   2 red (n - 2 red)
            // *...   1 red (n - 3 red)
            //*/ 
            //for (int i = n-1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= n ; j++)
            //    {
            //        if (i == j) Console.Write('*');
            //        else Console.Write('.');
            //    }
            //    Console.WriteLine();
            //}

            //Version 2:

            int n = int.Parse(Console.ReadLine());
            int starPosition = 1;

            for (int i = 1; i <= 2 * n - 1; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == starPosition) Console.Write('*');
                    else Console.Write('.');
                }
                if (i < n) starPosition++;
                else starPosition--;
                Console.WriteLine();
            }
        }
    }
}
