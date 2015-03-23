using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Program that calculates the number of workdays between today and given date.\n");

        Console.Write("Enter a date (day, month, year): ");
        string date = Console.ReadLine();

        DateTime givenDate = DateTime.Parse(date);
        DateTime currentDate = DateTime.Now;
        DateTime startDate = currentDate;

        int workDay = 0;
        int holiday = 0;
        int weekends = 0;

        while (currentDate <= givenDate)
        {
            if (CheckIfHoliday(currentDate))
                ++holiday;
            else if (CheckIfWeekend(currentDate))
                ++weekends;
            else
                ++workDay;

            currentDate = currentDate.AddDays(1);
        }

        Console.WriteLine("The days from {0} to {1}:\nWorkdays: {2}\nHolidays: {3}\nWeekend days: {4}",
                           startDate, givenDate, workDay, holiday, weekends);
        Console.ReadLine();
    }

    static bool CheckIfHoliday(DateTime date)
    {
        DateTime[] holidays = { new DateTime(2015, 01, 1),
                                new DateTime(2015, 03, 3),
                                new DateTime(2015, 05, 1),
                                new DateTime(2015, 05, 6),
                                new DateTime(2015, 09, 22),
                                new DateTime(2015, 12, 24),
                                new DateTime(2015, 12, 25),
                                new DateTime(2015, 12, 26)  };

        bool isHoliday = false;

        foreach (var holiday in holidays)
        {
            if (date.Date == holiday.Date && date.Month == holiday.Month)
                isHoliday = true;
        }

        return isHoliday;
    }

    static bool CheckIfWeekend(DateTime date)
    {
        DayOfWeek saturday = DayOfWeek.Saturday;
        DayOfWeek sunday = DayOfWeek.Sunday;

        bool isWeekend = false;

        if (date.DayOfWeek == saturday ||
            date.DayOfWeek == sunday)
            isWeekend = true;

        return isWeekend;
    }
}
