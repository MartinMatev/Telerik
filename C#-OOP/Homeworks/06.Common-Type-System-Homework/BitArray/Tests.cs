using System;

namespace BitArray
{
    class Tests
    {
        static void Main()
        {
            BitArray64 firstNum = new BitArray64(2345775224);
            BitArray64 secondNum = new BitArray64(7211233456);

            Console.WriteLine("First number: {0}", firstNum);
            Console.WriteLine("Second number: {0}", secondNum);

            // Demonstrating the implementation of []
            Console.WriteLine("\nFirst number's bit at index 2: {0}", firstNum[2]);
            Console.WriteLine("First number's bit at index 4: {0}", firstNum[4]);

            firstNum[2] = 1;
            Console.WriteLine("\nFirst number's bit at index 2 changed to 1: {0}", firstNum[2]);
            Console.WriteLine("First number value after the bit change: {0}", firstNum);

            // Demonstrating Equals()
            Console.WriteLine("\nAre the 2 numbers equal? - {0}", firstNum.Equals(secondNum));
            Console.WriteLine("Is the first number equal to itself? - {0}", firstNum.Equals(firstNum));

            // Demonstrating the GetHashCode()
            Console.WriteLine("\nFirst number hashcode: {0}", firstNum.GetHashCode());
            Console.WriteLine("Second number hashcode: {0}", secondNum.GetHashCode());

            // Demonstrating the == and != operators
            Console.WriteLine("\nIs first number == second number: {0}", firstNum == secondNum);
            Console.WriteLine("Is first number != second number: {0}", firstNum != secondNum);

            // Demonstratng the IEnumerator:
            Console.WriteLine("\nFirst number bits:");
            foreach (var digit in firstNum)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}
