using System;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Program to convert binary numbers to hexadecimal numbers (directly).\n");

        string binaryNumber = "01001110";

        //Console.Write("Enter a binary number: ");
        //string binaryNumber = Console.ReadLine();

        int counter = binaryNumber.Length / 4;
        int startPosition = 0;
        int endPosition = binaryNumber.Length / counter;

        string hexadecimal = String.Empty;

        while (counter > 0)
        {
            string currentBinary = ConvertBinaryToHex(binaryNumber, startPosition, endPosition);

            switch (currentBinary)
            {
                case "0000": hexadecimal += '0'; break;
                case "0001": hexadecimal += '1'; break;
                case "0010": hexadecimal += '2'; break;
                case "0011": hexadecimal += '3'; break;
                case "0100": hexadecimal += '4'; break;
                case "0101": hexadecimal += '5'; break;
                case "0110": hexadecimal += '6'; break;
                case "0111": hexadecimal += '7'; break;
                case "1000": hexadecimal += '8'; break;
                case "1001": hexadecimal += '9'; break;
                case "1010": hexadecimal += 'A'; break;
                case "1011": hexadecimal += 'B'; break;
                case "1100": hexadecimal += 'C'; break;
                case "1101": hexadecimal += 'D'; break;
                case "1110": hexadecimal += 'E'; break;
                case "1111": hexadecimal += 'F'; break;
                default: Console.WriteLine("Something else...");
                    break;
            }

            --counter;
            startPosition += 4;

            if (counter != 0)
                endPosition = binaryNumber.Length / counter;
        }
        Console.WriteLine(hexadecimal);

        Console.ReadLine();
    }

    static string ConvertBinaryToHex(string binaryNum, int startPosition, int endPosition)
    {
        string currentBinary = String.Empty;

        for (int i = startPosition; i < endPosition; i++)
        {
            currentBinary += binaryNum[i];
        }
        return currentBinary;
    }
}
