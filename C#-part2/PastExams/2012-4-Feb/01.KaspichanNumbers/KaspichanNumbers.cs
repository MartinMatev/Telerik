using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KaspichanNumbers
{
    static void Main()
    {
        // array of 256 elements
        ulong numBase = 256;
        string[] arrayOfNumbers = GenerateNumberArray(numBase);

        // read input
        ulong inputNum = ulong.Parse(Console.ReadLine());

        // calculations
        string result = string.Empty;

        while (inputNum > 0)
        {
            ulong remainder = inputNum % numBase;
            result = arrayOfNumbers[remainder] + result;
            inputNum /= (ulong)numBase;
        }

        // output
        if (result == string.Empty)
        {
            Console.WriteLine('A');
        }
        else
        {
            Console.WriteLine(result);
        }        
    }

    private static string[] GenerateNumberArray(ulong numBase)
    {
        string[] arrayOfNumbers = new string[numBase];
        for (int i = 0; i < 256; i++)
        {
            if (i < 26)
            {
                arrayOfNumbers[i] = string.Format("{0}", (char)(i + 'A'));
            }
            else
            {
                arrayOfNumbers[i] = string.Format("{0}{1}", (char)((i / 26) - 1 + 'a'), (char)(i % 26 + 'A'));
            }

        }
        return arrayOfNumbers;
    }
}
