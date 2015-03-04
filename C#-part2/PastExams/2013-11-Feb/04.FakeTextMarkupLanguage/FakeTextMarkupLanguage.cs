using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class FakeTextMarkupLanguage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string currentLine = Console.ReadLine();
            int closeTagStartIndex = currentLine.IndexOf("</");

            while (closeTagStartIndex != -1)
            {
                int closeTagEndIndex = currentLine.IndexOf(">", closeTagStartIndex + 1);
                string tagName = currentLine.Substring(closeTagStartIndex + 2, closeTagEndIndex - closeTagStartIndex - 2);

                int openTagStart = currentLine.LastIndexOf(string.Format("<{0}>", tagName), closeTagStartIndex);
                int openTagEnd = openTagStart + tagName.Length + 2;
                string content = currentLine.Substring(openTagEnd, closeTagStartIndex - openTagEnd);

                switch (tagName)
                {
                    case "rev":
                        content = Reverse(content);
                        break;
                    case "toggle":
                        content = Toggle(content);
                        break;
                    case "lower":
                        content = content.ToLower();
                        break;
                    case "upper":
                        content = content.ToUpper();
                        break;
                    case "del":
                        content = string.Empty;
                        break;
                    default:
                        break;
                }
                // Remove the already used opening and closing LAST tag (last in, first out) and add the new
                // (reworked) content, depending on the tag that changed it
                currentLine = currentLine.Remove(openTagStart, closeTagEndIndex - openTagStart + 1);
                currentLine = currentLine.Insert(openTagStart, content);

                closeTagStartIndex = currentLine.IndexOf("</");
            }
            Console.WriteLine(currentLine);
        }
    }

    private static string Toggle(string content)
    {
        StringBuilder result = new StringBuilder();

        foreach (var letter in content)
        {
            if (char.IsLetter(letter))
            {
                if (char.IsLower(letter))
                {
                    result.Append(char.ToUpper(letter));
                }
                else
                {
                    result.Append(char.ToLower(letter));
                }
            }
            else
            {
                result.Append(letter);
            }
        }

        return result.ToString();
    }

    private static string Reverse(string content)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = content.Length - 1; i >= 0 ; i--)
        {
            reversed.Append(content[i]);
        }

        return reversed.ToString();
    }
}
