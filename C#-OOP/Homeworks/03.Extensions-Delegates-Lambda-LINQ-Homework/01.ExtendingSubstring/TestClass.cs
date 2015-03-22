/*
 * Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new 
 * StringBuilder and has the same functionality as Substring in the class String.
 */

using System;
using System.Text;

namespace _01.ExtendingSubstring
{
    class TestClass
    {
        static void Main()
        {
            StringBuilder testSb = new StringBuilder();

            for (int i = 32; i < 50; i++)
            {
                testSb.Append((char)i);
            }

            Console.Write("testSb original content: ");
            Console.WriteLine(testSb.ToString());

            testSb = testSb.Substring(2, 24);

            Console.Write("\nSubstring from index 2 up to 6: ");
            Console.WriteLine(testSb.ToString());
        }
    }
}
