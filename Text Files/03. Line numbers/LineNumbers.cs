using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that reads a text file and inserts line numbers in front of each of its lines.\n");

        string text = "..\\..\\..\\testFile.txt";
        string changedText = "..\\..\\result.txt";

        using (StreamReader reader = new StreamReader(text))
        {
            string line = reader.ReadLine();
            StreamWriter writer = new StreamWriter(changedText);
            int lineNum = 0;
            using (writer)
            {
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("Line {0}: {1}", lineNum, line);
                    line = reader.ReadLine();
                }
            }
        }

        Console.ReadLine();
    }
}
