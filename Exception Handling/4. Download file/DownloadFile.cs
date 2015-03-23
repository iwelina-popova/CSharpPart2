using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.\n");
        
        using (WebClient Client = new WebClient())
        {
            try
            {
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "a.mpeg");

                Console.WriteLine("The file was downloaded!");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("\n-> Error: You have entered an empty URL!");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("\n-> Error: You have entered an invalid URL!");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("\n-> Error: This method does not support simultaneous downloads!");
            }
            finally
            {
                Client.Dispose();
                Console.WriteLine("\nThat's all!\n");
            }
        }

        Console.ReadLine();
    }
}