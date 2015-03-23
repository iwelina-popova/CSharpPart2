﻿using System;

// Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Program to convert hexadecimal numbers to binary numbers (directly).\n");

        string hexNumber = "4E";

        //Console.Write("Please enter a number: ");
        //string hexNumber = Console.ReadLine();

        //  Вариант 1:

        string binaryNumber = String.Empty;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0': binaryNumber += "0000"; break;
                case '1': binaryNumber += "0001"; break;
                case '2': binaryNumber += "0010"; break;
                case '3': binaryNumber += "0011"; break;
                case '4': binaryNumber += "0100"; break;
                case '5': binaryNumber += "0101"; break;
                case '6': binaryNumber += "0110"; break;
                case '7': binaryNumber += "0111"; break;
                case '8': binaryNumber += "1000"; break;
                case '9': binaryNumber += "1001"; break;
                case 'A': binaryNumber += "1010"; break;
                case 'B': binaryNumber += "1011"; break;
                case 'C': binaryNumber += "1100"; break;
                case 'D': binaryNumber += "1101"; break;
                case 'E': binaryNumber += "1110"; break;
                case 'F': binaryNumber += "1111"; break;
                default: Console.WriteLine("Something else");
                    break;
            }
        }

        //  Вариант 2:

        //string binaryNumber = String.Empty;
        //string currentBinaryNumber = String.Empty;

        //for (int i = 0; i < hexNumber.Length; i++)
        //{
        //    int currentNumber = CheckHexNumber(hexNumber[i]);

        //    while (currentNumber > 0)
        //    {
                
        //        int currentBit = currentNumber % 2;
        //        currentBinaryNumber = currentBit.ToString() + currentBinaryNumber;
        //        currentNumber /= 2;
        //    }
        //    binaryNumber += currentBinaryNumber;
        //    currentBinaryNumber = String.Empty;
        //}

        Console.WriteLine("Hexadecimal: {0} -> binary: {1}", hexNumber, binaryNumber);

        Console.ReadLine();
    }

    static int CheckHexNumber(char element)
    {
        char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int position = 0;

        for (int i = 0; i < positions.Length; i++)
        {
            if (positions[i] == element)
                position = i;
        }

        return position;
    }
}
