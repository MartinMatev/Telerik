using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigits
{
    class BinaryDigits
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            while (n > ushort.MaxValue)
            {
                uint num =  n - ushort.MaxValue - 1;
                n = num;
            }

            string number = Convert.ToString(n, 2).PadLeft(16, '0');

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] - '0' == 1)
                {
                    sb1.Append(".#.");
                    sb2.Append("##.");
                    sb3.Append(".#.");
                    sb4.Append("###");
                }
                else
                {
                    sb1.Append("###");
                    sb2.Append("#.#");
                    sb3.Append("#.#");
                    sb4.Append("###");
                }
                if (i < number.Length - 1)
                {
                    sb1.Append(".");
                    sb2.Append(".");
                    sb3.Append(".");
                    sb4.Append(".");
                }
            }

            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sb3);
            Console.WriteLine(sb4);
        }
    }
}
