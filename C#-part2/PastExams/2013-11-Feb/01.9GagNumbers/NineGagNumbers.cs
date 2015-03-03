using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class NineGagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger decimalRepresentation = 0;
        long baseNum = 9;

        for (int i = 0; i < input.Length; i += 2)
        {
            int number = 0;
            char firstLetter = input[i];

            // I am ashamed of this switch....
            switch (firstLetter)
            {
                case '-': 
                    number = 0; 
                    break;
                case '*':
                    if (input[i + 1] == '*') 
                    {
                        number = 1;
                    }
                    else 
                    {
                        number = 6;
                        i += 2;
                    }
                    break;
                case '!':
                    if (input[i + 1] == '-')
                    {
                        number = 5;
                    }
                    else
                    {
                        if (input[i + 2] == '!')
                        {
                            number = 2;
                            i++;
                        }
                        else
                        {
                            number = 8;
                            i += 4;
                        }
                    }
                    break;
                case '&':
                    if (input[i + 1] == '*')
                    {
                        number = 7;
                        i++;
                    }
                    else
                    {
                        if (input[i + 1] == '&')
                        {
                            number = 3;
                        }
                        else
                        {
                            number = 4;
                        }
                    }
                    break;
            }

            // VER 2:
            // 1. Create a StringBuilder
            // 2. Add input[i] on every loop to the SB
            // 3. Switch the added thus far, checking if it is == ANY of the WORDS (a.k.a "-!", "*!!!", etc.)
            // 4. If it is, ADD the appropriate number, CLEAR the SB
            // 5, If it isn't, keep adding the next indexes of input to the SB

            decimalRepresentation *= baseNum;
            decimalRepresentation += number;
        }
        Console.WriteLine(decimalRepresentation);
    }
}
