using System;
using System.Text;

/*
 * Write a program that reads a string from the console 
 * and replaces all series of consecutive identical letters with a single one.
 * 
 * Example:
 * input	                    output
 * aaaaabbbbbcdddeeeedssaa	    abcdedsa
 */
class SeriesOfLetters
{
    static void Main()
    {
        string input = GetInput();
        Console.WriteLine("Output: {0}", ReplaceLetters(input));
    }

    private static string ReplaceLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }

    private static string GetInput()
    {
        Console.WriteLine("Enter string of consecutive identical letters and stuff: ");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
