using System;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
//the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Program that adds two positive integer numbers.\n");

        int firstNumber = 88298;
        int secondNumber = 4321;

        //Console.Write("Please enter first number: ");
        //int firstNumber = int.Parse(Console.ReadLine());
        //Console.Write("Please enter second number: ");
        //int secondNumber = int.Parse(Console.ReadLine());

        int[] firstNum = ReverseNumberAsArray(firstNumber);
        int[] secondNum = ReverseNumberAsArray(secondNumber);
        int sum = SumFirstAndSecond(firstNum, secondNum);

        Console.WriteLine("The sum: {0} + {1} = {2}", firstNumber, secondNumber, string.Join("", ReverseNumberAsArray(sum)));
        Console.ReadLine();
    }
    static int SumFirstAndSecond(int[] firstNumArray, int[] secondNumArray)
    {
        if (secondNumArray.Length < firstNumArray.Length)
            return SumFirstAndSecond(secondNumArray, firstNumArray);

        string sum = "";
        int temp = 0;
        int i = 0;

        for (i = 0; i < firstNumArray.Length; i++)
        {
            int currentSum = firstNumArray[i] + secondNumArray[i];
            sum += currentSum % 10 + temp;
            temp = currentSum / 10;
        }

        if (secondNumArray.Length >= i)
        {
            for (; i < secondNumArray.Length; i++)
            {
                sum += secondNumArray[i] + temp;
                temp = 0;
            }
        }
        if (temp != 0)
            sum += temp;

        int reversedSum = Convert.ToInt32(sum);

        return reversedSum;
    }

    static int[] ReverseNumberAsArray(int number)
    {
        string numberAsString = number.ToString();
        int[] reversedNumber = new int[numberAsString.Length];
        int counter = 0;

        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            reversedNumber[counter] = numberAsString[i] - '0';
            ++counter;
        }

        return reversedNumber;
    }

}