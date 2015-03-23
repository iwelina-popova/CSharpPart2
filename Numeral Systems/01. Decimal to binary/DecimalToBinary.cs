using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

// Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Program to convert decimal numbers to their binary representation.\n");

        long number = 152;

        //Console.Write("Please enter a number: ");
        //long number = long.Parse(Console.ReadLine());

        long decimalNumber = number;
        string binaryNumber = String.Empty;

        while (decimalNumber > 0)
        {
            long currentBit = decimalNumber % 2;
            binaryNumber = currentBit.ToString() + binaryNumber;
            decimalNumber /= 2;
        }

        Console.WriteLine("Decimal: {0} -> binary: {1}", number, binaryNumber);

        Console.ReadLine();
    }
}
