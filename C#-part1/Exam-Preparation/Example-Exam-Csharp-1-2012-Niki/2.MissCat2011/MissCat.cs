using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MissCat2011
{
    class MissCat
    {
        static void Main(string[] args)
        {
            /*
            // FIRST VERSION
            int n = int.Parse(Console.ReadLine());
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;
            for (int i = 1; i <= n; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());
                // TODO: check the vote
                if (vote == 1) c1++;
                if (vote == 2) c2++;
                if (vote == 3) c3++;
                if (vote == 4) c4++;
                if (vote == 5) c5++;
                if (vote == 6) c6++;
                if (vote == 7) c7++;
                if (vote == 8) c8++;
                if (vote == 9) c9++;
                if (vote == 10) c10++;
            }
            // TODO: determine the best cat
            // 10 more fucking ifs, checking if one beats all other cats....JEBUS
            //OR do this and copy paste the result and use it to get the correct answer!!!!
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 10) Console.WriteLine("c{0} => c{1}", i, j);
                    else Console.WriteLine("c{0} => c{1} && ", i, j);      
                }
            } 
         */
            int n = int.Parse(Console.ReadLine());
            int[] c = new int[11];
            for (int i = 0; i <= n; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());
                c[vote]++;
            }
            int bestCat = 0;
            int bestCatVotes = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (c[i] >= bestCatVotes)
                {
                    bestCat = i;
                    bestCatVotes = c[i];
                }
            }
            Console.WriteLine(bestCat);
        }
    }
}
