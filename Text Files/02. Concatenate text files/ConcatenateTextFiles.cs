using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Program that concatenates two text files into another text file.\n");

        string text1 = "..\\..\\text1.txt";
        string text2 = "..\\..\\text2.txt";
        string concatenatedTexts = "..\\..\\result.txt";

        ReadTextFromFile(text1, concatenatedTexts);
        ReadTextFromFile(text2, concatenatedTexts);

        using (StreamReader readText = new StreamReader(concatenatedTexts))
        {
            while(!readText.EndOfStream)
                Console.WriteLine(readText.ReadLine());
        }

        Console.ReadLine();
    }

    private static void ReadTextFromFile(string text, string concatenatedTexts)
    {
        using (StreamWriter result = new StreamWriter(concatenatedTexts, true))
        {
            using (StreamReader reader = new StreamReader(text))
            {
                while (!reader.EndOfStream) 
                    result.WriteLine(reader.ReadLine());
            }
        }
    }
}
