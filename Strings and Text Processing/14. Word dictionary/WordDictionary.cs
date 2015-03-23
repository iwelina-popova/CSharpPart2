using System;
using System.Collections.Generic;

/* A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	    output
.NET	    platform for applications from Microsoft
CLR	        managed execution environment for .NET
namespace	hierarchical organization of classes
 */

class WordDictionary
{
    static void Main()
    {
        Console.WriteLine("Program that enters a word and translates it by using the dictionary.\n");

        Dictionary<string, string> dic = new Dictionary<string, string> 
        { { ".NET", "platform for applications from Microsoft" },
          { "CLR", "managed execution environment for .NET" },
          { "namespace", "hierarchical organization of classes" }
        };

        string word = "CLR";

        if (dic.ContainsKey(word))
        {
            Console.WriteLine("{0} - {1}", word, dic[word]);
        }
        
        Console.ReadLine();
    }
}
