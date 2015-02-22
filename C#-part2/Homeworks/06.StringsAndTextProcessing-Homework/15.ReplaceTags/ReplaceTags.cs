using System;
using System.Text.RegularExpressions;

/*
 * Write a program that replaces in a HTML document given as string all the tags 
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 * Example:
 * 
 * input:	
 * 
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a 
 * href="www.devbg.org">our forum</a> to discuss the courses.</p>	
 * 
 * output:
 * 
 * <p>Please visit [URL=http://academy.telerik. com]
 * our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the 
 * courses.</p>
 */
class ReplaceTags
{
    static void Main()
    {
        // Input: <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
        string inputText = GetInput();
        Console.WriteLine("\nOutput:\n {0}", StringConversion(inputText));
    }

    private static string StringConversion(string inputText)
    {
        // Explanation: <a href =\"  AND  \">  are the hardcoded values which to replace (\" is escaped ")
        // (.*?) means there will be any kind of VALUES between the hardcoded parts that will be replaced (they are not gonna be changed but MUST be perserved after the change !)
        string valuesToBeReplaced = "<a href=\"(.*?)\">(.*?)</a>";
        string valuesReplacement = "[URL=$1]$2[/URL]";

        return Regex.Replace(inputText, valuesToBeReplaced, valuesReplacement);
    }

    private static string GetInput()
    {
        Console.WriteLine("Copy paste you input below: ");
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
