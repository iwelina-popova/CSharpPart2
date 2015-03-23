using System;
using System.Data;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

class LeapYear
{
    static void Main()
    {
        DateTime thisYear = DateTime.Now;

        if(DateTime.IsLeapYear(thisYear.Year))
            Console.WriteLine("This year {0} is a leap one.", thisYear.Year);
        else Console.WriteLine("This year {0} is not a leap one.", thisYear.Year);

        Console.ReadLine();
    }
}
