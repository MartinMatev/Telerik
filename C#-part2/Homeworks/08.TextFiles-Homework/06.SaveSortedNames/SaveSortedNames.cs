using System;
using System.IO;
/*
 * Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan        George
Peter       Ivan 
Maria       Maria 
George	    Peter        
 */
class SaveSortedNames
{
    static void Main()
    {
        string inputFile = @"../../../ProblemsTextFolder/06.UnsortedInput.txt";
        string outputFile = @"../../../ProblemsTextFolder/06.SortedOutput.txt";

        try
        {
            string[] inputFileLine = File.ReadAllLines(inputFile);
            Array.Sort(inputFileLine);
            File.WriteAllLines(outputFile, inputFileLine);
            Console.WriteLine("New file was created and strings have been sorted at : {0}", Path.GetFullPath(outputFile));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (EndOfStreamException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
