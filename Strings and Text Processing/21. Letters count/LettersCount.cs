using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a string from the console and prints all different letters in the string along with information
//how many times each letter is found.

class LettersCount
{
    static void Main()
    {
        Console.WriteLine(@"Program that reads a string from the console.
Than prints all different letters in the string along with information how many times each letter is found.");
        Console.WriteLine();

        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        string input = "Some people have names that are palindromes. For example - Ada, Anna, Bob, Aviva";

        char[] letters = input.ToLower().ToCharArray();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char letter in letters)
        {
            if (letter >= 'a' && letter <= 'z')
            {
                if (dict.ContainsKey(letter))
                    ++dict[letter];

                else
                    dict.Add(letter, 1);
            }
            
        }

        foreach (var item in dict)
        {
            Console.WriteLine("Letter '{0}' -> {1} time(s)", item.Key, item.Value);
        }

        Console.ReadLine();
    }
}
