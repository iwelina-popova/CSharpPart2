using System;

/* Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
 */ 

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Program that asks the user for his name and prints “Hello, <name>”\n");
        Console.Write("Please enter a name: ");
        string name = Console.ReadLine();
        PrintHello(name);

        Console.ReadLine();
    }

    static void PrintHello(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }
}
