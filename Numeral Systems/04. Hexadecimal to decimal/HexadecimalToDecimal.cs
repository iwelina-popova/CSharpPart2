using System;

// Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Program to convert hexadecimal numbers to their decimal representation.\n");

        string hexNumber = "36F";

        //Console.Write("Enter a hexadecimal number: ");
        //string hexNumber = Console.ReadLine();

        long decimalNumber = 0;
        int power = 1;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += CheckHexNumber(hexNumber[i]) * power;
            power *= 16;
        }

        Console.WriteLine("Hexadecimal: {0} -> decimal: {1}", hexNumber, decimalNumber);


        Console.ReadLine();
    }

    static int CheckHexNumber(char element)
    {
        char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int position = 0;

        for (int i = 0; i < positions.Length; i++)
        {
            if(positions[i] == element)
                position = i;
        }

        return position;
    }
}