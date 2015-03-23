using System;
using System.IO;

/* Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is "in"

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
                        So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */ 

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Program that finds how many times a sub-string is contained in a given text (perform case insensitive search).\n");

        string text = @"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
                        So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";

        //Console.Write("Enter a sub-string: ");
        //string substring = Console.ReadLine();

        string currentText = text.ToLower();
        int counter = 0;

        for (int i = 0; i <= currentText.Length - substring.Length; i++)
        {
            if (currentText.Substring(i, substring.Length) == substring)
                ++counter;
        }

        Console.WriteLine("The sub-string \"{0}\" containes {1} times.",substring, counter);

        Console.ReadLine();
    }
}
