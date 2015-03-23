using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/* Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#
</interest><interest>Java</interest></interests></student>
 */ 

class ExtractTextFromXML
{
    static void Main()
    {
        Console.WriteLine("Program that extracts from given XML file all the text without the tags.\n");

        using (StreamReader reader = new StreamReader("..\\..\\XMLFile.txt"))
        {
            string line = reader.ReadLine();
            string extract = string.Empty;
            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }
                        if (extract != "")
                        {
                            Console.WriteLine(extract.TrimStart(' '));
                            extract = "";
                        }
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}
