using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

class DatesInCanada
{
    static void Main()
    {
        Console.WriteLine("Program that extracts from a given text all dates that match the format DD.MM.YYYY.\n");

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        //Console.WriteLine("Enter a text:");
        //string text = Console.ReadLine();

        string text = "The weather was perfect on 1.12.2002 and 20.05.2015";
        
        string validDate = @"[\d]{1,2}.[\d]{1,2}.[\d]{4}";
        DateTime date;

        foreach (var match in Regex.Matches(text, validDate))
        {
            //DateTime date = Convert.ToDateTime(match.ToString(), Thread.CurrentThread.CurrentCulture);
            if(DateTime.TryParse(match.ToString(), Thread.CurrentThread.CurrentCulture, DateTimeStyles.None, out date))
            Console.WriteLine(date);
        }

        Console.ReadLine();
    }
}