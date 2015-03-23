using System;
using System.Linq;

/* Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
 */

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Program that returns the last digit of given integer as an English word.\n");

        int number = 115886;

        //Console.Write("Please enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        string numberAsString = number.ToString();
        int lastDigit = Convert.ToInt32(numberAsString[numberAsString.Length - 1] - '0');

        string digitAsWord = LastDigitIs(lastDigit);
        Console.WriteLine("The last digit of {0} as an English word is {1}", number, digitAsWord);

        Console.ReadLine();
    }

    static string LastDigitIs(int number)
    {
        string digitAsWord = "";
        string[] digitsAsWords = { 
                                 "zero", "one", "two", "three", "four",
                                 "five", "six", "seven", "eight", "nine"
                                 };

        for (int i = 0; i < digitsAsWords.Length; i++)
        {
            if (number == i) digitAsWord = digitsAsWords[i];
        }
        return digitAsWord;
    }
}
