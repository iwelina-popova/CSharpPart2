using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//Modify the solution of the previous problem to replace only whole words (not strings).

class ReplaceWholeWord
{
    static void Main()
    {

        Console.WriteLine("Replace only whole words.\n");

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
                int index = line.IndexOf("start");

                while (index != -1)
                {
                    if (((index == 0) || (!Char.IsLetter(line[index - 1]))) &&
                        ((index >= (line.Length - 5)) || (!Char.IsLetter(line[index + 5]))))
                    {
                        line = line.Insert(index, "finish").Remove(index + 6, 5);
                        index = line.IndexOf("start");
                    }
                    else
                    {
                        index = line.IndexOf("start", index + 1);
                    }
                }

                builder.Append(line);

                if (!reader.EndOfStream)
                {
                    builder.Append("\r\n");
                }

                line = reader.ReadLine();
            }
        }
    }
}
