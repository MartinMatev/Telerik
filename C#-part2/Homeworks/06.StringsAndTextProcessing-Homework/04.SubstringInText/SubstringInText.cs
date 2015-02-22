using System;
using System.Text.RegularExpressions;
/*
 * Write a program that finds how many times a sub-string is contained 
 * in a given text (perform case insensitive search).
 * 
 * Example:
 * 
 * The target sub-string is `in`
 * 
 * The text is as follows: 
 * 
 * We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
 
 * The result is: 9
 */
class SubstringInText
    {
        static void Main()
        {
            string keyWord = GetData("keyword");
            string text = GetData("text");//.Replace(" ", string.Empty);

            // Version 1: using Regex
            MatchCollection result = Regex.Matches(text, keyWord, RegexOptions.IgnoreCase);
            Console.WriteLine("\nThe result is: {0}", result.Count);

            ////Version 2: that other way, that is also slow and makes me type more. 
            //int result = CountSubstrings(keyWord, text);
            //Console.WriteLine("\nThe result is: {0}", result);
        }

        private static int CountSubstrings(string keyWord, string text)
        {
            var replacedStr = text.Replace(keyWord, string.Empty);
            return (text.Length - replacedStr.Length) / keyWord.Length;
        }

        private static string GetData(string p)
        {
            Console.WriteLine("Enter the {0} below: ", p);
            Console.Write(">> ");
            return Console.ReadLine();
        }
    }
