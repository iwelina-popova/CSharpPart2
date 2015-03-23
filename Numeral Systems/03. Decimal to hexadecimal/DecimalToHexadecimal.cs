using System;
using System.Text;

// Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Program to convert decimal numbers to their hexadecimal representation.\n");

        long number = 999;

        //Console.Write("Enter a decimal number: ");
        //long number = long.Parse(Console.ReadLine());

        long decimalNumber = number;
        string hexadecimalNum = String.Empty;

        while (decimalNumber > 0)
        {
            long currentBit = decimalNumber % 16;
            hexadecimalNum = CheckHexNumber(currentBit) + hexadecimalNum;
            decimalNumber /= 16;
        }

        Console.WriteLine("Decimal: {0} -> hexadecimal: {1}", number, hexadecimalNum);


        Console.ReadLine();
    }

    static char CheckHexNumber(long position)
    {
        char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        char element = positions[position];

        return element;
    }
}
