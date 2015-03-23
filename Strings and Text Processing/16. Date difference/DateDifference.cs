using System;

/* Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */ 

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Program that reads two dates in the format: day.month.year and calculates the number of days between them.\n");
        
        //Console.Write("Enter first date (day.month.year): ");
        //string first = Console.ReadLine();
        //Console.Write("Enter second date (day.month.year): ");
        //string second = Console.ReadLine();

        //DateTime firstDate = Convert.ToDateTime(first);
        //DateTime secondDate = Convert.ToDateTime(second);

        DateTime firstDate = new DateTime(2015, 03, 01);
        DateTime secondDate = new DateTime(2015, 03, 15);

        double countDays = Math.Abs((secondDate - firstDate).TotalDays);

        Console.WriteLine(countDays);

        Console.ReadLine();
    }
}
