using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Write a program that finds the maximal sequence of equal elements in an array.
/*Example:
        input	                        result
        2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 */ 
class MaximalSequence
{
    static void Main(string[] args)
    {
        // Enter the array, and EXPLODE (a.k.a Split) each digit
        Console.Write("Enter digits separated by comma or space: ");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        // Version 1 : Many loops for something that LINQ does better 
        int maxLength = 0;
        int value = 0;

        // Iterate through the array's ordered elements
        for (int i = 0; i < array.Length; i++)
        {
            int currentLength = 1;
            // Iterate through the rest of the array's elements and check for matches
            for (int j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[i] == array[j])
                {
                    currentLength++;
                }
                else
                {
                    break;
                }
            }

            if (currentLength >= maxLength)
            {
                maxLength = currentLength;
                value = array[i];   // initialize "value" with the most repetitive array element
            }
        }
        // Display the correct subset
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0} ", value);
        }
        Console.WriteLine();

        //// Version 2: using LINQ
        //// Find the largest sequel using LINQ (SQL like addition to .Net, used for querying objects etc.)
        //int[] largestSequence = array.Select((n, i) => new { Value = n, Index = i })
        //                .OrderBy(s => s.Value)
        //                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
        //                .GroupBy(s => new { s.Value, s.Diff })
        //                .OrderByDescending(g => g.Count())
        //                .First()
        //                .Select(f => f.Value)
        //                .ToArray();

        //foreach (int digit in largestSequence)
        //{
        //    Console.Write(digit + " ");
        //}
        //Console.WriteLine(); 
    }
}
