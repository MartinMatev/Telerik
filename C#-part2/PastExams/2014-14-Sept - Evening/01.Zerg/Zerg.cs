using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] alphabet = new string[]{"Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh"};

        long decimalRepresentation = 0;
        for (int i = 0; i < input.Length; i +=4)
        {
            int number = Array.IndexOf(alphabet, input.Substring(i, 4));
            decimalRepresentation *= 15;
            decimalRepresentation += number;
        }
        Console.WriteLine(decimalRepresentation);
    }
}
