using System;
using System.Text.RegularExpressions;

/*
 * We are given a string containing a list of forbidden words and a text containing some of these words.
 * Write a program that replaces the forbidden words with asterisks.
 * 
 * Example text: 
 * Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * 
 * Forbidden words: PHP, CLR, Microsoft
 * The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
class ForbiddenWords
{
    static void Main()
    {
        string inputText = GetInputText();
        string[] forbiddenWords = GetForbiddenWords();
        string words = String.Join("|", forbiddenWords);

        Console.WriteLine(Regex.Replace(inputText, words, x => new string('*', x.Length)));
    }

    private static string[] GetForbiddenWords()
    {
        Console.WriteLine("Type in fobidden words below, separated by comma or space: ");
        Console.Write(">> ");
        return Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
    }

    private static string GetInputText()
    {
        Console.WriteLine("Type in text below: ");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}