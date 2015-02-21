using System;
using System.Linq;

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
class OrderWords
{
    static void Main()
    {
        string[] input = GetInput();
        Array.Sort(input);

        Console.WriteLine("Sorted list of words (alphabetical order): ");
        foreach (var word in input)
        {
            Console.WriteLine(word);
        }
    }

    private static string[] GetInput()
    {
        Console.WriteLine("Enter a list of words, separated by spaces: ");
        Console.Write(">> ");
        return Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
