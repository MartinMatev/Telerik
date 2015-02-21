using System;
using System.Collections.Generic;

/*
 * A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 * Sample dictionary:
 * input	            output
 * .NET	                platform for applications from Microsoft
 * CLR	                managed execution environment for .NET
 * namespace	        hierarchical organization of classes
 */
class WordDictionary
{
    static void Main()
    {
        string input = GetInput();
        Console.WriteLine(">> {0}", OpenDictionary(input));
    }

    private static string OpenDictionary(string input)
    {
        Dictionary<string, string> poorDictionary = new Dictionary<string, string>();
        poorDictionary.Add(".NET", "platform for applications from Microsoft");
        poorDictionary.Add("CLR", "managed execution environment for .NET");
        poorDictionary.Add("namespace", "hierarchical organization of classes");
        string noMatch = "NO MATCHES FOUND, PLEASE PAYPAL ME MONEY SO I CAN UPDATE THE DICTIONARY!";

        foreach (var key in poorDictionary)
        {
            if (key.Key == input)
            {
                return key.Value;
            }
        }
        return noMatch;
    }

    private static string GetInput()
    {
        Console.WriteLine("Enter a word to search for its definition in the DICTIONARY.");
        Console.WriteLine("The dictionary is pretty poor and contains ONLy 3 words: .NET, CLR and namespace");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
