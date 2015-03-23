using System;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFileContents
{
    static void Main()
    {

        Console.WriteLine("program that enters file name (e.g. C:\\WINDOWS\\win.ini), reads its contents and prints it on the console.\n");

        string path = "C:\\WINDOWS\\win.ini";

        try
        {
            Console.WriteLine("Checking for this file and reading its content.\n");

            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("File's content was successfully readed!\n");
        }
        catch (AccessViolationException)
        {
            Console.WriteLine("No access to this file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory cannot be found!");
        }
        catch (DriveNotFoundException)
        {
            Console.WriteLine("The drive is not available!");
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("The stream is closed!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file cannot be found");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("The file was found but cannot be loaded!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("There no more memory!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path ot filename is longer than the system-defined maximum length!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The operating system has dinied access!");
        }


        Console.ReadLine();
    }
}
