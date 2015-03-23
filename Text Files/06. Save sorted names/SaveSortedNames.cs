using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	
Ivan 
Peter 
Maria 
George

 
output.txt
George
Ivan 
Maria 
Peter
 */

class SaveSortedNames
{
    static void Main()
    {
        Console.WriteLine("Program that reads a text file containing a list of strings, sorts them and saves them to another text file.\n");

        List<string> namesList = new List<string>();

        ReadFile(namesList);
        namesList.Sort();
        WriteToFile(namesList);
    }

    private static void WriteToFile(List<string> namesList)
    {
        using (StreamWriter writer = new StreamWriter("..\\..\\sortedNames.txt", false, Encoding.UTF8))
        {
            foreach (string name in namesList)
            {
                writer.WriteLine(name);
            }
        }
    }

    private static void ReadFile(List<string> namesList)
    {
        using (StreamReader reader = new StreamReader("..\\..\\names.txt", Encoding.UTF8))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                namesList.Add(line);
                line = reader.ReadLine();
            }
        }
    }

}