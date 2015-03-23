using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        Console.WriteLine("Program that creates an array containing all letters from the alphabet (A-Z).\n");

        // Вариант 1 - с готови стойности

        //string givenWord = "have";
        string givenWord = "binary";


        // Вариант 2 - ръчно въвеждане

        //Console.Write("Please enter a word: ");
        //string givenWord = Console.ReadLine();

        string word = givenWord.ToUpper();

        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write("{0} ", j);
                }
            }
        }

        Console.ReadLine();
    }
}

