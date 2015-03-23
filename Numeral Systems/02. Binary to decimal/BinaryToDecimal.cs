using System;

// Write a program to convert binary numbers to their decimal representation.

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Program to convert binary numbers to their decimal representation.\n");

        string binaryNumber = "10011000";

        //Console.Write("Enter a binary number: ");
        //string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;
        int power = 1;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (binaryNumber[i] - '0') * power;
            power *= 2;
        }

        Console.WriteLine("Binary: {0} -> decimal: {1}", binaryNumber, decimalNumber);

        Console.ReadLine();
    }
}
