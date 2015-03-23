using System;
using System.Text.RegularExpressions;

/* Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.
We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */ 

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Program that extracts from a given text all sentences containing given word.\n");

        //Console.WriteLine("Enter a text:");
        //string text = Console.ReadLine();
        //Console.Write("Enter a word: ");
        //string word = Console.ReadLine();

        string text = @"We are living in a yellow submarine. We don't have anything else. 
                        Inside the submarine is very tight. 
                        So we are drinking all the day.
                        We will move out of it in 5 days.";

        string word = "in";

        string[] splitedText = text.Split('.');

        for (int i = 0; i <= splitedText.Length - word.Length; i++)
        {
            if(CheckIfContains(splitedText[i], word))
                Console.WriteLine(splitedText[i].Trim() + ".");
        }

        Console.Read();

    }

    private static bool CheckIfContains(string sentence, string word)
    {
        if (Regex.Matches(sentence, string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count == 0)
            return false;
        else
            return true;
    }
}
