using System;
using System.Linq;

/* Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
 */ 

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Program that reads a string, reverses it and prints the result at the console.\n");

        string input = "sample";

        //Console.Write("Please enter a string: ");
        //string input = Console.ReadLine();

        string output = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            output += input[i];
        }

        Console.WriteLine("The string \"{0}\" reversed: \"{1}\"", input, output);

        Console.ReadLine();
    }
}