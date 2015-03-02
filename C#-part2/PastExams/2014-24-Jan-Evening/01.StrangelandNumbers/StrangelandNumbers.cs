using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StrangelandNumbers
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        long decimalValue = 0;
        int digit = 0;
        for (int i = 0; i < inputText.Length; i++)
        {
            char firstSymbol = inputText[i];
            if (char.IsLower(firstSymbol))
            {
                switch (firstSymbol)
                {
                    case 'f': digit = 0; break;
                    case 'b': digit = 1; break;
                    case 'o': digit = 2; break;
                    case 'm': digit = 3; break;
                    case 'l': digit = 4; break;
                    case 'p': digit = 5; break;
                    case 'h': digit = 6; break;
                    default: break;
                }
                decimalValue *= 7;
                decimalValue += digit;
            }
        }
        Console.WriteLine(decimalValue);
    }
}
