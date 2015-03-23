using System;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

class OneSystemToOther
{
    static void Main()
    {
        Console.WriteLine("Program to convert from any numeral system of given base s to any other numeral system of base d (2 <= s, d >= 16).\n");

        int firstSystem = 10;
        int secondSystem = 16;
        string number = "77";

        while (firstSystem < 2 && secondSystem > 16)
        {
            //Console.Write("Enter first numeral system: ");
            //int firstSystem = int.Parse(Console.ReadLine());
            //Console.Write("Enter second numeral system: ");
            //int secondSystem = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number to convert: ");
            //string number = Console.ReadLine();
        }

        long firstConvert = ConvertToDecimal(firstSystem, number);
        string result = ConvertToSecondSystem(secondSystem, firstConvert);
        Console.WriteLine("Your number in {0}-system: {1} -> in {2}-system: {3}", firstSystem, number, secondSystem, result);



        Console.ReadLine();
    }

    static long ConvertToDecimal(int system, string number)
    {
        long decimalNumber = 0;
        int power = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (system == 16)
                decimalNumber += CheckHexIndex(number[i]) * power;
            else
                decimalNumber += (number[i] - '0') * power;

            power *= system;
        }
        return decimalNumber;
    }

    static string ConvertToSecondSystem(int system, long decimalNumber)
    {
        string newSystemNumber = String.Empty;

        while (decimalNumber > 0)
        {
            long currentBit = decimalNumber % system;
            if (system == 16)
                newSystemNumber = CheckHexElement(currentBit) + newSystemNumber;
            else
                newSystemNumber = currentBit + newSystemNumber;
            decimalNumber /= system;
        }
        return newSystemNumber;
    }

    static int CheckHexIndex(char element)
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

    static char CheckHexElement(long position)
    {
        char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        char element = positions[position];

        return element;
    }
}
