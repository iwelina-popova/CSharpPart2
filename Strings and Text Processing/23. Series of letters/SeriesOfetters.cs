using System;
using System.Collections.Generic;

/* Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                output
aaaaabbbbbcdddeeeedssaa	abcdedsa
 */ 

class SeriesOfetters
{
    static void Main()
    {
        Console.WriteLine("Program that reads a string from the console and replaces all series of consecutive identical letters with a single one.\n");

        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        string input = "aaaaabbbbbcdddeeeedssaa";

        Console.Write(input[0]);
        for (int i = 1; i < input.Length; i++)
        {            
            if(input[i - 1] != input[i])
                Console.Write(input[i]);
        }


        Console.ReadLine();
    }
}
