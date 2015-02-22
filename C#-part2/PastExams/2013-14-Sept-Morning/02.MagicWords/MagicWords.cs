using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        // Add words
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        // Reverse them (REORDER)
        for (int i = 0; i < n; i++)
        {
            string currentWord = words[i];
            int newPosition = currentWord.Length % (n + 1);


            words[i] = null; // Вмъква NULL на мястото на старата дума (същата позиция)
            words.Insert(newPosition, currentWord); // Слага си старата дума на новата й позиция
            words.Remove(null); // Маха null

        }

        // Get the lenght of the lengthiest word
        int maxLength = words.Max(x => x.Length);

        // PRINT
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)   // Check if the length of the current word is bigger than the current length (`i`). A fix for smaller words, so we can skip em
                {
                    result.Append(word[i]);
                }            
            }
        }

        Console.WriteLine(result.ToString());
    }
}
