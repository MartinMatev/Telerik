using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfN = n / 2;
            int quarterN = n / 4;
            char fire = '#';
            char torchTop = '-';
            char torchLeft = '\\';
            char torchRight = '/';
            char blank = '.';

            // .Append == Console.Write
            // .AppendLine == Console.WriteLine
            StringBuilder result = new StringBuilder();

            // Fire top part
            for (int i = 0; i < halfN; i++)
            {
                result.Append(new string(blank, halfN - (i + 1)));
                result.Append(fire);
                result.Append(new string(blank, i * 2));
                result.Append(fire);
                result.AppendLine(new string(blank, halfN - (i + 1)));
            }

            // Fire bottom part
            for (int i = 0; i < quarterN; i++)
            {
                result.Append(new string(blank, i));
                result.Append(fire);
                result.Append(new string(blank, n - (i * 2) - 2));
                result.Append(fire);
                result.AppendLine(new string(blank, i));
            }

            // Torch top
            result.AppendLine(new string(torchTop, n));

            // Torch bottom
            for (int i = 0; i < halfN; i++)
            {
                result.Append(new string(blank, i));
                result.Append(new string(torchLeft, halfN - i));
                result.Append(new string(torchRight, halfN - i));
                result.AppendLine(new string(blank, i));                
            }
            Console.WriteLine(result);
        }
    }
}
