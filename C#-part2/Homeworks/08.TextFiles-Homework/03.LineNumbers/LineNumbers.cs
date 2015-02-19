using System;
using System.IO;

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.
class LineNumbers
{
    static void Main()
    {
        string noLinesFile = @"../../../ProblemsTextFolder/03.NoLinesFile.txt";
        string linesFile = @"../../../ProblemsTextFolder/03.LinesFile.txt";

        StreamReader readerStream = new StreamReader(noLinesFile);
        StreamWriter writerStream = new StreamWriter(linesFile);

        using (readerStream)
        {
            using (writerStream)
            {
                int lineCounter = 0;
                string line = readerStream.ReadLine();

                while (line != null)
                {
                    lineCounter++;
                    writerStream.WriteLine("{0}. {1}", lineCounter, line);
                    line = readerStream.ReadLine();
                }
                Console.WriteLine("New file was created and lines were added at : {0}", Path.GetFullPath(linesFile));
            }
        }
    }
}
