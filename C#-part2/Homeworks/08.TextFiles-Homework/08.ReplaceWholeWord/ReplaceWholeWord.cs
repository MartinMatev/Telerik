using System;
using System.IO;
using System.Text.RegularExpressions;

// Modify the solution of the previous problem to replace only whole words (not strings).
class ReplaceWholeWord
{
    static void Main()
    {
        // Practically everything is the same EXCEPT "start" from the previous assignment
        // is now @"\bstart\b" to take into account ONLY whole words
        string startFile = @"../../../ProblemsTextFolder/08.StartFile.txt";
        string finishFile = @"../../../ProblemsTextFolder/08.FinishFile.txt";


        try
        {
            using (StreamReader startFileContent = new StreamReader(startFile))
            {
                // Displaying the original file, before the changes
                string[] allLines = File.ReadAllLines(startFile);
                Console.WriteLine("Contents of original file: ");
                PrintFile(allLines);

                string line = startFileContent.ReadLine();
                using (StreamWriter finishFileContent = new StreamWriter(finishFile))
                {
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"\bstart\b", "finish");
                        finishFileContent.WriteLine(line);
                        line = startFileContent.ReadLine();
                    }
                }
                Console.WriteLine("\nNew file was created and only WHOLE STRINGS have been changed at : {0}\n", Path.GetFullPath(finishFile));

                // Displaying the newly created file, with WHOLE WORDS ONLY changed
                string[] changedLines = File.ReadAllLines(finishFile);
                Console.WriteLine("Contents of changed file: ");
                PrintFile(changedLines);
            }
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

    private static void PrintFile(string[] allLines)
    {
        for (int i = 0; i < allLines.Length; i++)
        {
            Console.WriteLine(allLines[i]);
        }
    }
}
