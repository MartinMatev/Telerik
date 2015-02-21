using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
 * Write a program that reverses the words in given sentence.
 * Example:
 * 
 * input	                                    output
 * C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!
 */
class ReverseSentence
{
    static void Main()
    {
        string input = GetInput();
        SentenceReverser(input);
    }

    private static void SentenceReverser(string input)
    {
        // A regex string, containing all of the punctation
        // \s+|,\s*|   => matches `,`
        // \.          => matches `.`
        // \s*|!\s*|   => matches `!`
        // \s+|;\s*|   => matches `;`
        string punctuation = @"\s+|,\s*|\.\s*|!\s*|\s+|;\s*|$";
        Stack<string> words = new Stack<string>();

        // Push words in Stack, separating them of anyy punctuation signs that they are concatenated with
        // i.e:  C++, / Delphi! will push only C++ / Delphi in the Stack
        foreach (var word in Regex.Split(input, punctuation))
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Push(word);
            }
        }

        foreach (var sign in Regex.Matches(input, punctuation))
        {
            // Break if there's nothing more in the stack
            if (words.Count <= 0) break;

            PrintResult(words.Pop() + sign);
        }
        Console.WriteLine();
    }

    private static void PrintResult(string result)
    {
        Console.Write(result);
    }

    private static string GetInput()
    {
        Console.WriteLine("Write the sentence to reverse its words below: ");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
