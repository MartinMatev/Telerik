using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TresFourNumbers
{
    static void Main()
    {
        var digits = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        ulong numeralSystem = 9;
        ulong numberInDecimal = ulong.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        do
        {
            int digitIn9th = (int)(numberInDecimal % numeralSystem);
            result.Insert(0, digits[digitIn9th]);
            numberInDecimal /= numeralSystem;
        }
        while (numberInDecimal > 0);
        Console.WriteLine(result.ToString());
    }
}
