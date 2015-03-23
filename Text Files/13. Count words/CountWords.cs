﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/* Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
 */

class CountWords
{
    static void Main()
    {
        Console.WriteLine(@"Program that reads a list of words from the file words.txt and finds how many times 
each of the words is contained in another file test.txt.");
        Console.WriteLine();

        try
        {
            string[] text = ReadText();
            string[] words = ReadWords();
            Dictionary<string, int> wordsDictionary = CountWordsOccurance(text, words);
            PrintResult(wordsDictionary);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (DirectoryNotFoundException dnf)
        {
            Console.WriteLine(dnf.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine(oe.Message);
        }
        catch (OutOfMemoryException ome)
        {
            Console.WriteLine(ome.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }

    private static void PrintResult(Dictionary<string, int> wordsDictionary)
    {
        var sortedDictionary = wordsDictionary.OrderByDescending(x => x.Value);

        using (StreamWriter writer = new StreamWriter("..\\..\\result.txt"))
        {
            string output = string.Empty;

            foreach (var item in sortedDictionary)
            {
                writer.WriteLine("The word '{0}' appears {1} times in the text.", item.Key, item.Value);
            }
        }
    }

    private static Dictionary<string, int> CountWordsOccurance(string[] text, string[] words)
    {
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        int counter = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == words[i])
                {
                    counter++;
                }
            }

            wordsDictionary.Add(words[i], counter);
            counter = 0;
        }

        return wordsDictionary;
    }

    private static string[] ReadText()
    {
        string[] text;

        using (StreamReader reader = new StreamReader("..\\..\\test.txt"))
        {
            text = reader.ReadToEnd().Replace("\r\n", " ").Replace(".", " ").Split(' ');
        }

        return text;
    }

    private static string[] ReadWords()
    {
        string[] words;

        using (StreamReader reader = new StreamReader("..\\..\\words.txt"))
        {
            words = reader.ReadToEnd().Replace("\r\n", " ").Split(' ');
        }

        return words;
    }
}
