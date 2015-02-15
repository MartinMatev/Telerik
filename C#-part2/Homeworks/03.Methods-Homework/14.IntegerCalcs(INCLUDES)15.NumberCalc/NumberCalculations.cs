using System;
using System.Linq;

/* 
 * Problem 14. Integer calculations

 * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 * Use variable number of arguments.
 * 
 * Problem 15.* Number calculations
 * 
 * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte,
 * etc.)
 * Use generic method (read in Internet about generic methods in C#)
 */
class NumberCalculations
{
    static void Main()
    {
        int[] intArray = { 1221, 2, 332, 43, 12 };
        decimal[] decimalArray = { 1.245673m, 1.23m, 7.3892134m, 457.234m, 1337.7331m};
        float[] floatArray = { 1.337f, 13.37f, 133.7f, 0.1337f };

        Console.WriteLine("INT arr Min: {0}", CalculateMin(intArray));
        Console.WriteLine("DECIMAL arr Min: {0}", CalculateMin(decimalArray));
        Console.WriteLine("FLOAT arr Min: {0}", CalculateMin(floatArray));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("INT arr Max: {0}", CalculateMax(intArray));
        Console.WriteLine("DECIMAL arr Max: {0}", CalculateMax(decimalArray));
        Console.WriteLine("FLOAT arr Max: {0}", CalculateMax(floatArray));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("INT arr Average: {0}", CalculateAverage(intArray));
        Console.WriteLine("DECIMAL arr Average: {0}", CalculateAverage(decimalArray));
        Console.WriteLine("FLOAT arr Average: {0}", CalculateAverage(floatArray));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("INT arr Sum: {0}", CalculateSum(intArray));
        Console.WriteLine("DECIMAL arr Sum: {0}", CalculateSum(decimalArray));
        Console.WriteLine("FLOAT arr Sum: {0}", CalculateSum(floatArray));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("INT arr Product: {0}", CalculateProduct(intArray));
        Console.WriteLine("DECIMAL arr Product: {0}", CalculateProduct(decimalArray));
        Console.WriteLine("FLOAT arr Product: {0}", CalculateProduct(floatArray));
    }

    private static T CalculateProduct<T>(params T[] array) where T : IComparable<T>
    {
        return array.Aggregate<T, dynamic>(1, (x, y) => x * y);
    }

    private static T CalculateSum<T>(params T[] array) where T : IComparable<T>
    {
        return array.Aggregate<T, dynamic>(0, (x, y) => x + y);    
    }

    private static T CalculateMax<T>(params T[] array) where T : IComparable<T>
    {
        return array.Max();
    }

    private static T CalculateMin<T>(params T[] array) where T : IComparable<T>
    {
        return array.Min();
    }

    private static T CalculateAverage<T>(params T[] array) where T : IComparable<T>
    {
        // Needed because operator Sum(), * and Average() do NOT apply to generic variables/arrays
        dynamic sum = array.Aggregate<T, dynamic>(0, (x, y) => x + y);
        // Aggregate: Applies an accumulator function over a sequence.
        return sum / array.Length;
    }
}
