﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DurankulakNumbers
{
    static void Main()
    {
        long numbase = 168;
        string[] alphabetArray = GenerateNumberArray(numbase);


        string input = Console.ReadLine();

        long decimalRepresentation = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int index = 0;
            if (char.IsUpper(input[i]))
            {
                index = Array.IndexOf(alphabetArray, input[i].ToString());
                // Ver.2 IF NO ALPHABET ARRAY:
                //index = input[i] - 'A';
            }
            else
            {
                string letter = string.Format("{0}{1}", input[i], input[i + 1]);
                index = Array.IndexOf(alphabetArray, letter);
                i++;
                // Ver.2 IF NO ALPHABET ARRAY
                //index += (input[i] - 'a' + 1) * 26;
                //index += input[i + 1] - 'A';
                //i++;
            }

            decimalRepresentation *= numbase;
            decimalRepresentation += index;
        }
        Console.WriteLine(decimalRepresentation);
    }

    private static string[] GenerateNumberArray(long numbase)
    {
        string[] alphabetArray = new string[numbase];
        for (int i = 0; i < 168; i++)
        {
            if (i < 26)
            {
                alphabetArray[i] = string.Format("{0}", (char)(i + 'A'));
            }
            else
            {
                alphabetArray[i] = string.Format("{0}{1}", (char)(i / 26 - 1 + 'a'), (char)(i % 26 + 'A'));
            }
        }

        return alphabetArray;
    }
}
