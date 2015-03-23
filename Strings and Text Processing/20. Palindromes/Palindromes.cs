using System;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.\n");

        //Console.WriteLine("Enter a text:");
        //string input = Console.ReadLine();

        string input = @"Palindrome is word, phrase, number which reads the same backward or forward - ABBA. 
                         More  exmaples: civic, radar, level, kayak and refer.";

        string[] words = input.Split(new[] { " ", ", ", ". " }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            bool isSame = false;
            int middle = word.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                    isSame = true;                
            }

            if(isSame)
                Console.WriteLine(word);
        }

        Console.ReadLine();
    }
}
