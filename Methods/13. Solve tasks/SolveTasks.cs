using System;

/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

class SolveTasks
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please choose:");

            Console.WriteLine("1. Program that reverses the digits of a number.");
            Console.WriteLine("2. Program that calculates the average of a sequence of integers.");
            Console.WriteLine("3. Program that solves a linear equation a * x + b = 0");
            Console.WriteLine();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    ReverseNumber();
                    break;
                case 2: 
                    Average();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;

                default: Console.WriteLine("Please enter 1, 2 or 3");
                    Console.WriteLine();
                    break;
            }
        }

    }
    

    static void ReverseNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        string numberAsString = number.ToString();
        string reversedNumber = "";

        for (int i = 0; i < numberAsString.Length; i++)
        {
            reversedNumber += numberAsString[i];
        }

        Console.WriteLine("Your number: {0}", number);
        Console.WriteLine("Your number reversed: {0}", reversedNumber);
    }

    static void Average()
    {
        Console.Write("Enter a number of the integers you'll input: ");
        int counter = int.Parse(Console.ReadLine());

        decimal[] numbersArray = new decimal[counter];
        decimal sum = 0;

        for (int i = 0; i < counter; i++)
        {
            Console.Write("Enter number that is no 0 {0}: ", i+1);
            while (numbersArray[i] == 0)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
                sum += numbersArray[i];
            }
            
        }
        decimal average = sum / counter;

        Console.WriteLine("Your numbers are: {0}", string.Join(", ", numbersArray));
        Console.WriteLine("The average is: {0}", average);
    }


    static void SolveLinearEquation()
    {
        Console.WriteLine("a*x + b = 0");
        Console.WriteLine("Please enter two numbers.");
        Console.Write("First number (a != 0): ");
        double firstNumber = double.Parse(Console.ReadLine());
        while (firstNumber == 0)
        {
            Console.WriteLine("Please enter a number different than 0!");
            firstNumber = double.Parse(Console.ReadLine());
        }
        Console.Write("Second number (b): ");
        double secondNumber = double.Parse(Console.ReadLine());

        double result = -(secondNumber / firstNumber);

        Console.WriteLine("The result is: x = {0}", result);
    }
}
