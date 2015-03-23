using System;

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("Program that prints to the console which day of the week is today.\n");

        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}.", today.DayOfWeek);

        Console.ReadLine();
    }
}
