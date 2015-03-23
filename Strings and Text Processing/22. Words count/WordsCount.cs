using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and lists all different words in the string along with information
//how many times each word is found.

class WordsCount
{
    static void Main()
    {
        Console.WriteLine(@"Write a program that reads a string from the console.
Than lists all different words in the string along with information how many times each word is found.");

        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        string input = "I have cat and dog and rabbit and horse. Now I want snake.";

        string[] words = input.ToLower().Split(new[] { " ", ", ", ".", "-", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
                ++dict[word];

            else
                dict.Add(word, 1);
        }

        foreach (var item in dict)
        {
            Console.WriteLine("Word '{0}' -> {1} time(s)", item.Key, item.Value);
        }

        Console.ReadLine();
    }
}
