using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class OnesAndZeros
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());

            // Version 1:
            while (input > ushort.MaxValue)
            {
                uint number = input - ushort.MaxValue - 1;
                input = number;
            }
            char[] charArray = Convert.ToString(input, 2).PadLeft(16, '0').ToCharArray();

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();

            for (int i = 0; i < charArray.Length; i++)  // Version 2: i = charArray.Lenght - 16.... etc
            {
                if (charArray[i] == '1')
                {
                    sb1.Append(".#.");
                    sb2.Append("##.");
                    sb3.Append(".#.");
                    sb4.Append(".#.");
                    sb5.Append("###");
                }
                else
                {
                    sb1.Append("###");
                    sb2.Append("#.#");
                    sb3.Append("#.#");
                    sb4.Append("#.#");
                    sb5.Append("###");
                }
                if (i < charArray.Length - 1)
                {
                    sb1.Append(".");
                    sb2.Append(".");
                    sb3.Append(".");
                    sb4.Append(".");
                    sb5.Append(".");
                }
            }
            Console.WriteLine(sb1.ToString());
            Console.WriteLine(sb2.ToString());
            Console.WriteLine(sb3.ToString());
            Console.WriteLine(sb4.ToString());
            Console.WriteLine(sb5.ToString());
        }
    }
}
