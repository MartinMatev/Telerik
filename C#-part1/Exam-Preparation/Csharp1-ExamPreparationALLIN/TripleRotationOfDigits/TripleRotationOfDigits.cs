using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationOfDigits
{
    class TripleRotationOfDigits
    {
        static void Main(string[] args)
        {
            uint k = uint.Parse(Console.ReadLine());
            int remainder = 0;
            string newNum = "";
            int lenght = 3;

            if (k > 9 && k < 99)
            {
                lenght = 1;
            }
            for (int i = 0; i < lenght; i++)
            {
                remainder = (int)(k % 10);
                k /= 10;
                newNum = remainder + newNum;
                newNum = newNum.TrimStart('0');
            }
            if (k != 0)
            {
                Console.WriteLine(newNum + k.ToString());
            }
            else
            {
                Console.WriteLine(newNum);
            }
        }
    }
}
