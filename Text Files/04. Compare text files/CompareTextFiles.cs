using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine(@"Program that compares two text files line by line and prints the number of lines that are the same 
and the number of lines that are different.");
        Console.WriteLine();

        //files are in 'bin/Debug' directory of the project
        StreamReader firstReader = new StreamReader("..\\..\\firstText.txt");
        StreamReader secondReader = new StreamReader("..\\..\\secondText.txt");

        using (firstReader)
        {
            using (secondReader)
            {
                string linesFirstText = firstReader.ReadLine();
                string linesSecondText = secondReader.ReadLine();

                int count = 1;

                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();

                while (linesFirstText != null)
                {
                    if (linesFirstText.Equals(linesSecondText))
                    {
                        sameLines.Add(count);
                    }
                    else
                    {
                        differentLines.Add(count);
                    }

                    count++;

                    linesFirstText = firstReader.ReadLine();
                    linesSecondText = secondReader.ReadLine();
                }

                Console.WriteLine("Same lines: {0}", string.Join(", ", sameLines));
                Console.WriteLine("Different lines: {0}", string.Join(", ", differentLines));
            }
        }
    }
}