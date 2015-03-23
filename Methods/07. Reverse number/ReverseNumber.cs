using System;

/* Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
123.45	54.321
 */ 

class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Program that reverses the digits of given decimal number.\n");

            decimal number = 123.45M;

            //Console.Write("Please enter a number: ");
            //decimal number = decimal.Parse(Console.ReadLine());

            decimal reversedNumber = ReverseANumber(number);
            Console.WriteLine(reversedNumber);

            Console.ReadLine();
        }

        static decimal ReverseANumber(decimal number)
        {
            decimal reversedNumber = 0;
            string givenNumber = number.ToString();
            string givenNumberReversed = "";

            for (int i = givenNumber.Length - 1; i >= 0; i--)
            {
                givenNumberReversed += givenNumber[i];
            }

            reversedNumber = Convert.ToDecimal(givenNumberReversed);

            return reversedNumber;
        }
    }
