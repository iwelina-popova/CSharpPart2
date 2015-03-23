﻿using System;

/* Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */ 

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Program that reads an integer number and calculates and prints its square root.\n");

        Console.WriteLine("Enter an integer: ");

        try
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
                throw new ArgumentException();

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root {0} = {1}", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

        Console.ReadLine();
    }
}