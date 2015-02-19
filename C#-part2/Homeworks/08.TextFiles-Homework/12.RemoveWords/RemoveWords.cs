using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Security;

// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.
class RemoveWords
{
    static void Main()
    {
        string keywordsFilePath = @"../../../ProblemsTextFolder/12.KeywordsFile.txt";
        string removeFromFilePath = @"../../../ProblemsTextFolder/12.RemoveFromFile.txt";
        List<string> wordsToRemove = new List<string>();
        StringBuilder filteredText = new StringBuilder();

        try
        {
            // Displaying the original file, before the changes
            string[] lines = File.ReadAllLines(removeFromFilePath);
            Console.WriteLine("Contents of original file: ");
            PrintFile(lines);

            using (StreamReader reader = new StreamReader(keywordsFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] text = reader.ReadLine().Split(' ')
                                           .ToArray();

                    wordsToRemove.AddRange(text);
                }
            }

            using (StreamReader reader = new StreamReader(removeFromFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] text = reader.ReadLine().Split(' ')
                                            .Where(word => !wordsToRemove.Contains(word))
                                            .ToArray();

                    filteredText.AppendLine(String.Join(" ", text));
                }
            }

            using (StreamWriter writer = new StreamWriter(removeFromFilePath))
            {
                writer.Write(filteredText);
            }

            Console.WriteLine("\nReworked file has been saved at : {0}\n", Path.GetFullPath(removeFromFilePath));

            // Displaying the reworked file, after the changes
            lines = File.ReadAllLines(removeFromFilePath);
            Console.WriteLine("Contents of reworked file: ");
            PrintFile(lines);
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

    private static void PrintFile(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
