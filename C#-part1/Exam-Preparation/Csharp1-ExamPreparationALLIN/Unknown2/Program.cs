using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int index = 0;
            long result = 0;

            while (text[index] != '@')
            {
                if (text[index] - '0' >= 0 && text[index] - '0' <= 9)
                {
                    result *= (text[index] - '0');
                }
                else if ((text[index] >= 65 && text[index] <= 90) ||
                        (text[index] >= 97 && text[index] <= 122))
                {
                    if (text[index] >= 65 && text[index] <= 90)
                    {
                        result += text[index] - 'A';
                    }
                    else if (text[index] >= 97 && text[index] <= 122)
                    {
                        result += text[index] - 'a';
                    }
                }
                else
                {
                    result %= m;
                }

                index++;
            }
            Console.WriteLine(result);
        }
    }
}
