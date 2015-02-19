using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;

/*
 * Write a program that reads a list of words from the file words.txt and finds how many times 
 * each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be sorted by the number of their 
 * occurrences in descending order. Handle all possible exceptions in your methods.
 */
class CountWords
{
    static void Main()
    {
        string keyWordsPath = @"../../../ProblemsTextFolder/13.Words.txt";
        string testFilePath = @"../../../ProblemsTextFolder/13.Test.txt";
        string resultFilePath = @"../../../ProblemsTextFolder/13.Result.txt";
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        try
        {
            string[] keyWords = File.ReadAllLines(keyWordsPath);

            using (StreamReader reader = new StreamReader(testFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < keyWords.Length; i++)
                    {
                        // Regex \bkeyWord\b each word to see if we have a match in the restFile. \bsome word\b takes into account only WHOLE words, not substrings
                        string keyWord = @"\b" + keyWords[i] + @"\b";
                        MatchCollection matches = Regex.Matches(line, keyWord, RegexOptions.IgnoreCase);

                        // Check if the dictionary already contains a KEY with the keyWord and up it's VALUE (counter) by the number of matches, else ADD the KEY (keyWord)
                        if (dict.ContainsKey(keyWords[i]))
                        {
                            dict[keyWords[i]] += matches.Count;
                        }
                        else
                        {
                            dict.Add(keyWords[i], matches.Count);
                        }
                    }
                }
            }
            dict.OrderByDescending(x => x.Value);

            using (StreamWriter writer = new StreamWriter(resultFilePath))
            {
                foreach (var item in dict)
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
            Console.WriteLine("\nReworked file has been saved at : {0}\n", Path.GetFullPath(resultFilePath));
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (EndOfStreamException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
