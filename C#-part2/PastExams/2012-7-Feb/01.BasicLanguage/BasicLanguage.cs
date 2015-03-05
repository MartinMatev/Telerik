using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class BasicLanguage
{
    static StringBuilder output = new StringBuilder();
    static List<string> allCommands = new List<string>();
    static void Main()
    {
        ReadInput();
        ConvertInputToCommands();
        RunCommands();

        Console.WriteLine(output);
    }

    private static void RunCommands()
    {
        for (int i = 0; i < allCommands.Count; i++)
        {
            string[] subCommands = allCommands[i].Split(new char[]{')'}, StringSplitOptions.RemoveEmptyEntries);
            int allLoops = 1;

            foreach (var command in subCommands)
            {
                string currentCommand = command.TrimStart();

                if (currentCommand.StartsWith("EXIT"))
                {
                    return;
                }
                else if (currentCommand.StartsWith("PRINT"))
                {
                    int paramsStart = currentCommand.IndexOf("(") + 1;  // to start from the next symbol after "("
                    string content = currentCommand.Substring(paramsStart);

                    for (int j = 0; j < allLoops; j++)
                    {
                        output.Append(content);
                    }
                }
                else if (currentCommand.StartsWith("FOR"))
                {
                    int paramsStart = currentCommand.IndexOf("(") + 1;  // to start from the next symbol after "("
                    string allParams = currentCommand.Substring(paramsStart);

                    if (allParams.Contains(","))     // check with type of FOR loop we have
                    {
                        string[] loopParams = allParams.Split(',');

                        int a = int.Parse(loopParams[0]);
                        int b = int.Parse(loopParams[1]);

                        allLoops = allLoops * (b - a + 1);
                    }
                    else
                    {
                        int value = int.Parse(allParams);

                        allLoops = allLoops * value;
                    }
                }
            }
        }
    }

    private static void ConvertInputToCommands()
    {
        string allInput = output.ToString();
        output.Clear();

        foreach (var symbol in allInput)
        {
            output.Append(symbol);

            if (symbol == ';')
            {
                allCommands.Add(output.ToString());
                output.Clear();
            }
        }
    }

    private static void ReadInput()
    {
        while (true)
        {
            string line = Console.ReadLine();
            output.Append(line);

            if (line.Contains("EXIT;"))
            {
                break;
            }
        }
    }
}
