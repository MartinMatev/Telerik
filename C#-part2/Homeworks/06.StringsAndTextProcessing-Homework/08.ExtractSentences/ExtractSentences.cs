using System;
using System.Text;

/*
 * Write a program that extracts from a given text all sentences containing given word.
 * Example:
 * 
 * The word is: in
 * 
 * The text is: 
 * We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
 * 
 * The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
 * 
 * Consider that the sentences are separated by . and the words – by non-letter symbols.
 */
class ExtractSentences
{
    static void Main()
    {
        string keyWord = GetKeyWord();
        keyWord = " " + keyWord + " ";  // Add spaces around the word, so it looks only for whole words alike, not substrings
        string[] inputText = GetInputText();

        Console.WriteLine("\nResult: {0}", Extraction(keyWord, inputText));
    }

    private static string Extraction(string keyWord, string[] inputText)
    {
        StringBuilder result = new StringBuilder();
        foreach (var sentence in inputText)
        {
            if (sentence.Contains(keyWord))
            {
                result.Append(sentence);
                result.Append('.');
            }
        }
        return result.ToString();
    }

    private static string[] GetInputText()
    {
        Console.WriteLine("Type in text below: ");
        Console.Write(">> ");
        return Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
    }

    private static string GetKeyWord()
    {
        Console.Write("Type the key word: ");
        return Console.ReadLine();
    }
}