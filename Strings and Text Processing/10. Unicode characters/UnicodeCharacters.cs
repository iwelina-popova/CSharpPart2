using System;
using System.Text;

/* Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	    \u0048\u0069\u0021
 */ 

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Program that converts a string to a sequence of C# Unicode character literals.\n");

        //Console.Write("Enter a string: ");
        //string input = Console.ReadLine();

        string input = "Hi!";

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)input[i]);           
        }

        Console.ReadLine();
    }
}