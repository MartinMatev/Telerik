/*
 * Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
 * sum, product, min, max, average.
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.ExtendingIEnumerable
{
    class ExtensionTest
    {
        static void Main()
        {
            IEnumerable<double> doubleCollection = new List<double> { 2.5, 3.7, 8, 1.2 };
            IEnumerable<long> longCollection = new long[] { 27, 445, 21, 5};

            Console.Write("Sum of double collection: ");
            Console.WriteLine(doubleCollection.Sum());
            Console.Write("Sum of long collection: ");
            Console.WriteLine(longCollection.Sum());
            Console.WriteLine();

            Console.Write("Product of double collection: ");
            Console.WriteLine(doubleCollection.Product());
            Console.Write("Product of long collection: ");
            Console.WriteLine(longCollection.Product());
            Console.WriteLine();

            Console.Write("Min of double collection: ");
            Console.WriteLine(doubleCollection.Min());
            Console.Write("Min of long collection: ");
            Console.WriteLine(longCollection.Min());
            Console.WriteLine();

            Console.Write("Max of double collection: ");
            Console.WriteLine(doubleCollection.Max());
            Console.Write("Max of long collection: ");
            Console.WriteLine(longCollection.Max());
            Console.WriteLine();

            Console.Write("Average of double collection: ");
            Console.WriteLine(doubleCollection.Average());
            Console.Write("Average of long collection: ");
            Console.WriteLine(longCollection.Average());
        }
    }
}
