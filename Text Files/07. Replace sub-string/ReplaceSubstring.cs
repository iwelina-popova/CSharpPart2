using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

class ReplaceSubstring
{
    static void Main()
    {
        Console.WriteLine("Program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.\n");

        StringBuilder builder = new StringBuilder();

        ReplaceWords(builder);
        WriteFileWithNewText(builder);
    }

    private static void WriteFileWithNewText(StringBuilder builder)
    {
        using (StreamWriter writer = new StreamWriter("..\\..\\text.txt"))
        {
            writer.Write(builder);
        }
    }

    private static void ReplaceWords(StringBuilder builder)
    {
        using (StreamReader reader = new StreamReader("..\\..\\text.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                builder.Append(line).Replace("start", "finish");

                if (!reader.EndOfStream)
                {
                    builder.Append("\r\n");
                }

                line = reader.ReadLine();
            }
        }
    }
}
