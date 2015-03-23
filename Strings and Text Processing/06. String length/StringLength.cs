using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
//the rest of the characters should be filled with *.
//Print the result string into the console.

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Program that reads from the console a string of maximum 20 characters.\n");
                
        //Console.WriteLine("Please enter a string with maximum 20 characters:");
        //string input = Console.ReadLine();

        string input = "Hello my friend.";

        if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }
        else if (input.Length > 20)
        {
            Console.WriteLine("This string has more than 20 characters. It's with {0}!", input.Length);
        }

        Console.WriteLine(input);

        Console.ReadLine();
    }
}