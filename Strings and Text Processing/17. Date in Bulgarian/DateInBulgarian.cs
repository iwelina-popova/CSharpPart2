using System;
using System.Globalization;
using System.Threading;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and 
//time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Program that reads a date and time given in the format: day.month.year hour:minute:second");
        Console.WriteLine("Than prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.\n");
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        //Console.Write("Enter date (day.month.year hour:minute:second): ");
        //string currentDate = Console.ReadLine();
        //DateTime date = Convert.ToDateTime(currentDate);

        DateTime date = new DateTime(2015, 02, 20, 20, 15, 10);

        DateTime newDate = date.AddHours(6).AddMinutes(30);
        DayOfWeek dayOfWeek = newDate.DayOfWeek;

        Console.WriteLine("Date and time after 6 hours and 30 minutes: {0}", newDate);
        Console.WriteLine("Day of week: {0}", dayOfWeek);

        Console.ReadLine();
    }
}
