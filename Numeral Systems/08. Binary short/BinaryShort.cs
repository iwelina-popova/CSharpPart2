using System;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Program that shows the binary representation of given 16-bit signed integer number (the C# type short).\n");

        int number = -152;

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        int decimalNumber = number;

        if (decimalNumber < 0)
            decimalNumber = short.MaxValue + decimalNumber + 1;

        string binaryNumber = String.Empty;

        while (decimalNumber > 0)
        {
            int currentBit = decimalNumber % 2;
            binaryNumber = currentBit.ToString() + binaryNumber;
            decimalNumber /= 2;
        }

        
        if (number > 0)
            Console.WriteLine("Decimal: {0} -> binary: {1}", number, binaryNumber.PadLeft(16, '0'));
        else
            Console.WriteLine("Decimal: {0} -> binary: {1}", number, binaryNumber.PadLeft(16, '1'));

        Console.ReadLine();
    }
}
