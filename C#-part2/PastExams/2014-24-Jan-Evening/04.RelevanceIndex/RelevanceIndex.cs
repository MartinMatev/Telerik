using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class RelevanceIndex
{
    static void Main()
    {
        string searchWord = Console.ReadLine();
        int paragraphsNum = int.Parse(Console.ReadLine());
        string[] text = new string[paragraphsNum];
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < paragraphsNum; i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', '.', ',', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int relevanceIndexCount = 0;

            for (int j = 0; j < currentLine.Length; j++)
            {
                if (currentLine[j].ToLower() == searchWord.ToLower())
                {
                    relevanceIndexCount++;
                    currentLine[j] = currentLine[j].ToUpper();
                }
            }
            text[i] = string.Join(" ", currentLine);
            dict.Add(text[i], relevanceIndexCount);
        }
        var result = dict.OrderByDescending(x => x.Value);
        foreach (var line in result)
        {
            Console.WriteLine("{0}", line.Key);
        }
        
    }
}
