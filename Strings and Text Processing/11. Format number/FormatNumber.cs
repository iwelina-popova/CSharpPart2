using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.\n");

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        int number = 1184;

        Console.WriteLine("Decimal: {0, 15:D}", number);
        Console.WriteLine("Hexadecimal: {0, 15:X}", number);
        Console.WriteLine("Percentage: {0, 15:P}", number);
        Console.WriteLine("Scientific notation: {0, 15:E}", number);

        Console.ReadLine();
    }
}
