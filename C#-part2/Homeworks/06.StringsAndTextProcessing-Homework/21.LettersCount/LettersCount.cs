using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
class LettersCount
{
    static void Main()
    {
        string input = GetInput();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        // Loop every char, check if it exists in the KEYS of the dictionary, up the VALUE counter if so, else add it to the KEYS
        for (int i = 0; i < input.Length; i++)
        {
            if (dict.ContainsKey(input[i]))
            {
                dict[input[i]]++;
            }
            else
            {
                dict.Add(input[i], 1);
            }
        }
        Console.WriteLine("\nResult:");
        Console.WriteLine("{0}", String.Join("\n", dict.Select(x => String.Format("The letter '{0}' - appears {1} time/s", x.Key, x.Value)).OrderBy(x => x)));
    }

    private static string GetInput()
    {
        Console.WriteLine("Type in string below:");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
