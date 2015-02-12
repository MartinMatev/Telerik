using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two integer arrays from the console and compares them element by element.
class CompareArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter first array's digits separated by comma or space: ");
        int[] firstArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int firstArrayLength = firstArray.Length;

        Console.Write("Enter second array's digits separated by comma or space: ");
        int[] secondArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int secondArrayLength = secondArray.Length;
        if (firstArrayLength != secondArrayLength)
        {
            Console.WriteLine("Both of the arrays must have the same size!");
            return;
        }

        // Version 1 : Element by element
        for (int i = 0; i < 4; i++)
        {
            for (int j = i; j <= i; j++)
            {
                if (firstArray[i] == secondArray[j])
                {
                    Console.WriteLine("{0, -5} == {1, 5}", firstArray[i], secondArray[j]);
                }
                else
                {
                    Console.WriteLine("{0, -5} != {1, 5}", firstArray[i], secondArray[j]);
                }
            }
        }

        //// Version 2: using .Net's functionality - Does NOT show the 1 by 1 comparison, still does it though.
        //bool areArraysEqual = firstArray.SequenceEqual(secondArray);

        //if (areArraysEqual)
        //{
        //    Console.WriteLine("The two arrays are equal!");
        //}
        //else
        //{
        //    Console.WriteLine("The two arrays are NOT equal (takes into account positioning)");
        //}
    }
}
