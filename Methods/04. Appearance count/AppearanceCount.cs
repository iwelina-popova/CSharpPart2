using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Program that counts how many times given number appears in given array.\n");

        int number = 5;
        int[] numbersArray = { 5, 8, 6, 5, 4, 5 };

        //Console.Write("Please enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.Write("Please enter a length of the array of number: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbersArray = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element [{0}]: ", i);
        //    numbersArray[i] = int.Parse(Console.ReadLine());
        //}

        int countNumbers = CountNumbersInArray(numbersArray, number);
        Console.WriteLine("The array is: [{0}]", string.Join(", ", numbersArray));
        Console.WriteLine("The number {0} appers in this array {1} times.", number, countNumbers);

        Console.ReadLine();
    }

    static int CountNumbersInArray(int[] numbersArr, int number)
    {
        int counter = 0;
        for (int i = 0; i < numbersArr.Length; i++)
        {
            if (number == numbersArr[i]) counter++;
        }
        return counter;
    }
}
