using System;
using System.Linq;
using System.Collections.Generic;

// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
class WordsCount
{
    static void Main()
    {
        string[] inputText = GetInput();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // Loop every string, check if it exists in the KEYS of the dictionary, up the VALUE counter if so, else add it to the KEYS
        for (int i = 0; i < inputText.Length; i++)
        {
            if (dict.ContainsKey(inputText[i]))
            {
                dict[inputText[i]]++;
            }
            else
            {
                dict.Add(inputText[i], 1);
            }
        }

        Console.WriteLine("\nResult: ");
        Console.WriteLine("{0}", String.Join("\n", dict.Select(x => String.Format("The word \"{0}\" appears - {1} time/s", x.Key, x.Value)).OrderBy(x => x)));
    }

    private static string[] GetInput()
    {
        Console.WriteLine("Enter string text below, separating words with space: ");
        Console.Write(">> ");
        return Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
