using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConsoleJustification
{
    static int height;
    static int width;
    static List<string> words;
    static void Main()
    {
        ReadInput();

        StringBuilder result = new StringBuilder();
        string currentLine = string.Empty;
        int currentLineWordsCount = 0;
        int spacesToAdd;
        int indexToAddSpace;

        for (int i = 0; i < words.Count; i++)
        {
            if (currentLine.Length + words[i].Length <= width)
            {
                currentLine += string.Format("{0} ", words[i]);
                currentLineWordsCount++;
                continue;
            }
            // trim last space (който се слага по default след всяка дума от по-горе)
            currentLine = currentLine.Trim();
            spacesToAdd = width - currentLine.Length;
            indexToAddSpace = currentLine.IndexOf(" ");
            if (currentLineWordsCount != 1)
            {
                for (int j = 0; j < currentLineWordsCount && spacesToAdd > 0; j++)
                {
                    int spaces = (int)Math.Ceiling(spacesToAdd / (double)(currentLineWordsCount - j - 1));
                    currentLine = currentLine.Insert(indexToAddSpace, new string(' ', spaces));
                    indexToAddSpace = currentLine.IndexOf(' ', indexToAddSpace + spaces + 1);
                    spacesToAdd -= spaces;
                }
            }
                result.AppendLine(currentLine);
                currentLine = string.Format("{0} ", words[i]);
                currentLineWordsCount = 1;           
        }

        // trim last space (който се слага по default след всяка дума от по-горе)
        currentLine = currentLine.Trim();
        spacesToAdd = width - currentLine.Length;
        indexToAddSpace = currentLine.IndexOf(" ");
        if (currentLineWordsCount != 1)
        {
            for (int j = 0; j < currentLineWordsCount && spacesToAdd > 0; j++)
            {
                int spaces = (int)Math.Ceiling(spacesToAdd / (double)(currentLineWordsCount - j - 1));
                currentLine = currentLine.Insert(indexToAddSpace, new string(' ', spaces));
                indexToAddSpace = currentLine.IndexOf(' ', indexToAddSpace + spaces + 1);
                spacesToAdd -= spaces;
            }
        }

        result.Append(currentLine);

        Console.WriteLine(result);
    }

    private static void ReadInput()
    {
        height = int.Parse(Console.ReadLine());
        width = int.Parse(Console.ReadLine());
        words = new List<string>();

        for (int i = 0; i < height; i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < currentLine.Length; j++)
            {
                words.Add(currentLine[j]);
            }           
        }
    }
}
