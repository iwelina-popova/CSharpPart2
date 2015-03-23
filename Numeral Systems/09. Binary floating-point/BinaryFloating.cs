using System;

/* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
Example:

number	sign	exponent	mantissa
-27,25	1	    10000011	10110100000000000000000
 */ 

class BinaryFloating
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).\n");

        double number = 152.52;

        //Console.Write("Enter a floating-point number: ");
        //float number = float.Parse(Console.ReadLine());

        string floatNumber = number.ToString();

        
    }
}
