using System;

// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.
class SayHello
{
    static void Main(string[] args)
    {
        string name = GetName();
        Console.WriteLine("Hello, {0}!", name);
    }

    private static string GetName()
    {
        Console.Write("Please enter your name, so I can greet you...: ");
        return Console.ReadLine();
    }
}
