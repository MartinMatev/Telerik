using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string[] inputWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = inputWords.OrderByDescending(x => x.Length).First();
        StringBuilder extractedLetters = new StringBuilder();

        // Construct weird word
        for (int i = 0; i < longestWord.Length; i++)
        {
            foreach (var word in inputWords)
            {
                if (i < word.Length)
                {
                    int lastLetter = word.Length - i - 1;
                    extractedLetters.Append(word[lastLetter]);
                }
            }
        }
        int length = extractedLetters.Length;
        // Move around the letters of the weird word
        for (int i = 0; i < length; i++)
        {
            char currentSymbol = extractedLetters[i];
            int symbolAlphabetIndex = char.ToLower(currentSymbol) - 'a' + 1;
            int newSymbolIndex = (symbolAlphabetIndex + i) % length;

            extractedLetters.Remove(i, 1);  // remove the symbol from it's original position
            extractedLetters.Insert(newSymbolIndex, currentSymbol); // move the symbol to the new position
        }
        Console.WriteLine(extractedLetters.ToString());
    }
}
