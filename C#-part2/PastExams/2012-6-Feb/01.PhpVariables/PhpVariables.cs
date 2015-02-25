using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class PhpVariables
{
    static string ReadInput()
    {
        string currentLine = Console.ReadLine();
        StringBuilder phpCode = new StringBuilder();

        while (currentLine != "?>")
        {
            phpCode.AppendLine(currentLine);
            currentLine = Console.ReadLine().Trim();
        }

        return phpCode.ToString();
    }
    private static HashSet<string> ExtractWords(string inputCode)
    {
        HashSet<string> allVariables = new HashSet<string>();
        StringBuilder currentVariable = new StringBuilder();

        bool inOneLineCommnet = false;
        bool inMultiLineComment = false;
        bool inSIngleQuoteString = false;
        bool inDoubleQuoteString = false;
        bool inVariable = false;

        for (int i = 0; i < inputCode.Length; i++)
        {
            char currentSymbol = inputCode[i];

            // we are in one line comment
            if (inOneLineCommnet)
            {
                if (currentSymbol == '\n')
                {
                    // one line comment ends here
                    inOneLineCommnet = false;
                    continue;
                }
                else
                {
                    // we are still in one line comment
                    continue;
                }
            }

            // we are in multi line commnet
            if (inMultiLineComment)
            {
                if (currentSymbol == '*' && 
                    i + 1 < inputCode.Length && 
                    inputCode[i + 1] == '/')
                {
                    inMultiLineComment = false;
                    i++;    // next symbol is checked, we do not need it
                    continue;
                }
                else
                {
                    // we are still in multi line comment
                    continue;
                }
            }

            // we are in variable
            if (inVariable)
            {
                if (isValidVariableSymbol(currentSymbol))
                {
                    currentVariable.Append(currentSymbol);
                    continue;
                }
                else
                {
                    if (currentVariable.Length > 0)
                    {
                        allVariables.Add(currentVariable.ToString());
                    }                  
                    currentVariable.Clear();
                    inVariable = false;
                }
            }

            // we are in single quote string
            if (inSIngleQuoteString)
            {
                if (currentSymbol == '\'')
                {
                    inSIngleQuoteString = false;
                    continue;
                }
            }

            // we are in double quote string
            if (inDoubleQuoteString)
            {
                if (currentSymbol == '\"')
                {
                    inDoubleQuoteString = false;
                    continue;
                }
            }

            if (!inSIngleQuoteString && !inDoubleQuoteString)
            {
                // starting one line comment with #
                if (currentSymbol == '#')
                {
                    inOneLineCommnet = true;
                    continue;
                }
                // starting one line comment with //
                if (currentSymbol == '/' &&
                    i + 1 < inputCode.Length &&
                    inputCode[i+1] == '/')
                {
                    inOneLineCommnet = true;
                    i++;
                    continue;
                }
                // starting multi line comment
                if (currentSymbol == '/' &&
                    i + 1 < inputCode.Length &&
                    inputCode[i + 1] == '*')
                {
                    inMultiLineComment = true;
                    i++;
                    continue;
                }
            }
            else
            {
                // we are in string and next symbol must be escaped
                if (currentSymbol == '\\')
                {
                    i++;
                    continue;
                }
            }
            // we are starting single quote string
            if (currentSymbol == '\'')
            {
                inSIngleQuoteString = true;
                continue;
            }
            // we are starting double quote string
            if (currentSymbol == '\"')
            {
                inDoubleQuoteString = true;
                continue;
            }

            if (currentSymbol == '$')
            {
                inVariable = true;
            }
        }
        return allVariables;
    }

    private static bool isValidVariableSymbol(char symbol)
    {
        if (char.IsLetterOrDigit(symbol) || symbol == '_')
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        string inputCode = ReadInput();
        var result = ExtractWords(inputCode);
        PrintResult(result);
    }

    private static void PrintResult(HashSet<string> result)
    {
        Console.WriteLine(result.Count);
        foreach (var variable in result)
        {
            Console.WriteLine(variable);
        }
    }
}
