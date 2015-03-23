using System;
using System.Text;

/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */ 

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.\n");

        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder changedText = new StringBuilder();
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        bool upperCase = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                upperCase = true;
                i += startTag.Length;
            }
            while (upperCase)
            {
                if (text[i] == '<')
                {
                    upperCase = false;
                    i += endTag.Length;
                    break;
                }

                changedText.Append(text[i].ToString().ToUpper());
                ++i;
            }
            changedText.Append(text[i]);
        }

        Console.WriteLine(changedText);

        Console.ReadLine();
    }
}