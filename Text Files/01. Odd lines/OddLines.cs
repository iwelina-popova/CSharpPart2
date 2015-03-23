using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        Console.WriteLine("Program that reads a text file and prints on the console its odd lines.\n");

        using (StreamReader reader = new StreamReader("..\\..\\example.txt"))
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;

                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                } 

                line = reader.ReadLine();        
            }
        }


        Console.ReadLine();
    }
}
