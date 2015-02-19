using System;
using System.IO;
using System.Collections.Generic;

/*
 * Write a program that extracts from given XML file all the text without the tags.
 * Example:
 * 
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</
 * interest><interest>C#</interest><interest>Java</interest></interests></student>
 */
class ExtractXml
{
    static void Main()
    {
        string filePath = @"../../../ProblemsTextFolder/10.XML.txt";
        List<string> xmlValues = new List<string>();
        string line = null;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i < line.Length - 1 && line[i] == '>' && line[i + 1] != '<')
                        {
                            // take the index after '>'
                            int startingIndex = i + 1;
                            int lengthCount = 0;
                            while (line[i] != '<')
                            {
                                lengthCount++;
                                i++;
                            }
                            // Add the word, using the .Substring method, providing the starting index and the length of the word 
                            xmlValues.Add(line.Substring(startingIndex, lengthCount - 1));
                        }
                    }
                }
            }
            PrintResult(xmlValues);
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

    private static void PrintResult(List<string> xmlValues)
    {
        foreach (var value in xmlValues)
        {
            Console.WriteLine(value);
        }
    }
}
