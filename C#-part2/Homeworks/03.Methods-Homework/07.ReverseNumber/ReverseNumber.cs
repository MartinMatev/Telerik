using System;

/*
 * Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
 */
class ReverseNumber
{
    static void Main(string[] args)
    {
        GetNumber();
    }

    private static void GetNumber()
    {
        Console.Write("Type in decimal number: ");
        char[] number = Console.ReadLine().Trim('-').ToCharArray();
        Array.Reverse(number);
        PrintResult(new string(number));
    }

    private static void PrintResult(string number)
    {
        Console.WriteLine("Reversed number = {0}", number);
    }
}
