using System;
using System.Text;

/* Write a program that reverses the words in given sentence.
Example:

input	                                output
C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
 */

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Program that reverses the words in given sentence.\n");

        //Console.WriteLine("Enter a sentence:");
        //string sentence = Console.ReadLine();

        string sentence = "C# is not C++, not PHP and not Delphi!";

        string[] words = sentence.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
              
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ',')
            {
                ++count;
            }
        }        

        int[] comma = new int[count];
        count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if(words[i][words[i].Length - 1] == ',')
            {
                comma[count] = i;
                words[i] = words[i].Remove(words[i].Length - 1);
            }                
        }

        Array.Reverse(words);

        count = 0;
        char lastSign = sentence[sentence.Length - 1];
        StringBuilder output = new StringBuilder(sentence.Length);

        for (int i = 0; i < words.Length; i++)
        {
            if (i == comma[count])
            {
                output.Append(words[i] + ", ");

                if (comma.Length < count)
                    ++count;
            }
            else if (i == words.Length - 1)
                output.Append(words[i] + lastSign);

            else
            {
                output.Append(words[i] + " ");
            }
        }

        Console.WriteLine(output.ToString());

        Console.ReadLine();
    }
}
