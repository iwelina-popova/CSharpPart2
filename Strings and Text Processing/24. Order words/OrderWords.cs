using System;
using System.Linq;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Program that reads a list of words, separated by spaces and prints the list in an alphabetical order.\n");

        //Console.WriteLine("Enter words separated by space:");
        //string input = Console.ReadLine();

        string input = "horse dog cat rabbit human space";
        string[] words = input.ToLower().Split(new[] { " ", ", ", ".", "-", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
