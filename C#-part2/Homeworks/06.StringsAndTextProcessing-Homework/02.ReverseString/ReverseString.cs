using System;
using System.Text;
/*
 * Write a program that reads a string, reverses it and prints the result at the console.
 * 
 * Example:
 * input	output
 * sample	elpmas
 */
class ReverseString
{
    static void Main()
    {
        string input = ReadInput();
        StringReverse(input);
    }

    private static void StringReverse(string input)
    {
        StringBuilder reversedResult = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedResult.Append(input[i]);
        }
        PrintResult(reversedResult.ToString());
    }

    private static void PrintResult(string result)
    {
        Console.WriteLine("Reversed string: {0}", result);
    }

    private static string ReadInput()
    {
        Console.Write("Enter your string: ");
        return Console.ReadLine();
    }
}