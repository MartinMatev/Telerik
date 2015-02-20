using System;
using System.Text;

/*
 * Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 * 
 * Example:
input:	    output:
Hi!	        \u0048\u0069\u0021
 */
class UnicodeCharacters
{
    static void Main()
    {
        string input = GetInput();
        Console.WriteLine("Reformated string: {0}", Reformat(input)); 
    }

    private static string Reformat(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            result.AppendFormat("\\u{0:X4}", (int)c);
        }
        return result.ToString();
    }

    private static string GetInput()
    {
        Console.WriteLine("Type in string to reformat below: ");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}