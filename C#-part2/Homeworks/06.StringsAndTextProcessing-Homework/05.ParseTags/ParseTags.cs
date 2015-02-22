using System;
using System.Text;
using System.Text.RegularExpressions;

/*
 * You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to upper-case.
 * The tags cannot be nested.
 * 
 * Example: 
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * 
 * The expected result: 
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */
class ParseTags
{
    static void Main()
    {
        string inputText = GetInput();

        // Version 1: Regex and stuff. 2 lines. Happy times.
        string result = Regex.Replace(inputText, "<upcase>(.*?)</upcase>", x => x.Groups[1].Value.ToUpper());
        Console.WriteLine("\nResult:\n{0}", result);


        ////Version 2: that other way, again... I died a little inside.
        //string result = ChangeText(inputText);
        //Console.WriteLine("\nResult:\n{0}",result);
    }

    private static string ChangeText(string text)
    {
        string upcase = "<upcase>";
        string upcaseEnd = "</upcase>";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            bool upcaseCheck = false;
            StringBuilder tempSb = new StringBuilder();

            if (text[i] == '<' && text.Substring(i, 8) == upcase)
            {
                string upperCharacters = string.Empty;
                int index = i + upcase.Length;  // Make the index point right AFTER <upcase>

                while (text[index] != '<')
                {
                    tempSb.Append(text[index]);
                    index++;
                }

                // Check if we are at an opening tag '<' and the substring, starting from that tag is </upcase>
                if (text[index] == '<' && text.Substring(index, 9) == upcaseEnd)
                {
                    upcaseCheck = true;
                    result.Append(tempSb.ToString().ToUpper());
                    i = index + upcaseEnd.Length - 1;   // Assing the first index AFTER </upcase> as the new `i`
                }
            }

            if (upcaseCheck)
            {
                continue; 
            }
            result.Append(text[i]);
        }
        return result.ToString();
    }

    private static string GetInput()
    {
        Console.WriteLine("Type in the text with the appropriate tags:");
        Console.Write(">>");
        return Console.ReadLine();
    }
}
