using System;
using System.IO;
using System.Linq;
using System.Text;

// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.
class PrefixTest
{
    static void Main()
    {
        string filePath = @"../../../ProblemsTextFolder/11.PrefixTest.txt";
        string prefix = "test";
        StringBuilder filteredWords = new StringBuilder();

        try
        {
            // Displaying the original file, before the changes
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Contents of original file: ");
            PrintFile(lines);

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    // Readline the words, separating them whenever theres space, filtering the ones starting with `test`
                    string[] words = reader.ReadLine().Split(' ')
                                           .Where(word => !word.StartsWith(prefix))
                                           .ToArray();
                    // Implode (String.Join) the words back to a single line, add them to the string builder
                    filteredWords.AppendLine(String.Join(" ", words));
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(filteredWords);
            }

            Console.WriteLine("\nReworked file has been saved at : {0}\n", Path.GetFullPath(filePath));

            // Displaying the reworked file, after the changes
            lines = File.ReadAllLines(filePath);
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
    }

    private static void PrintFile(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}