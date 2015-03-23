using System;

/* You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	            output
"43 68 9 23 318"	461
 */

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Program that reads these values from given string and calculates their sum.\n");

        string numbers = "43 68 9 23 318";
        string[] positiveNumbers = numbers.Split(' ');

        //Console.WriteLine("Please enter a positive numbers separated by space:");
        //string[] positiveNumbers = Console.ReadLine().Split(' ');

        double sum = 0;

        for (int i = 0; i < positiveNumbers.Length; i++)
        {
            sum = sum + double.Parse(positiveNumbers[i]);
        }

        Console.WriteLine("The sum is: {0}", sum);

        Console.ReadLine();
    }
}
