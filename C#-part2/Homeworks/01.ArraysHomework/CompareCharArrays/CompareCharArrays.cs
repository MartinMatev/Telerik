using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two char arrays lexicographically (letter by letter)
class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.Write("Type in first string: ");
        char[] firstWord = Console.ReadLine().ToCharArray();
        Console.Write("Type in second string: ");
        char[] secondWord = Console.ReadLine().ToCharArray();
        int lesserLength = (int)Math.Min(firstWord.Length, secondWord.Length);
        // Implode the first word to a string and assign it as the first one (lexicographically)
        string lexicographicallyFirst = string.Join("", firstWord);

        Console.WriteLine("Lexicographycally compared (letter by letter): ");
        for (int i = 0; i < lesserLength; i++)
        {
            // If a letter in the second word is before it's counterpart (lexicographically)
            if (firstWord[i] > secondWord[i])
            {
                lexicographicallyFirst = string.Join("", secondWord);
                break;
            }
        }

        Console.WriteLine("Lexicographically first is: {0}", lexicographicallyFirst);
    }
}