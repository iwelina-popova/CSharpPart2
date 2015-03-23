using System;

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class LargestNumber
{
    static void Main()
    {
        Console.WriteLine("Program that reads 3 integers from the console and prints the largest of them using the method GetMax().\n");

        int firstNumber = 4;
        int secondNumber = 8;
        int thirdNumber = 1;

        //Console.Write("Please enter first number: ");
        //int firstNumber = int.Parse(Console.ReadLine());
        //Console.Write("Please enter first number: ");
        //int secondNumber = int.Parse(Console.ReadLine());
        //Console.Write("Please enter first number: ");
        //int thirdNumber = int.Parse(Console.ReadLine());
        
        int largestNumber = GetMax(firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("The largest number between {0}, {1} and {2} is: {3}", firstNumber, secondNumber, thirdNumber, largestNumber);

        Console.ReadLine();
    }

    static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
    {
        int maxNumber = firstNumber;
        if (secondNumber > maxNumber) maxNumber = secondNumber;
        else if (thirdNumber > maxNumber) maxNumber = thirdNumber;

        return maxNumber;
    }
}
