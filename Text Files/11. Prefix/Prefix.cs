using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

class Prefix
{
    static void Main()
    {
        Console.WriteLine("Program that deletes from a text file all words that start with the prefix test.\n");

        using (StreamReader reader = new StreamReader("..\\..\\prefix.txt"))
        {
            using (StreamWriter output = new StreamWriter("..\\..\\deletePrefix.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if ((line[0] != 't') || (line[1] != 'e') || (line[2] != 's') || (line[3] != 't'))
                    {
                        output.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("All words starting with \"test\" removed.");
    }
}
