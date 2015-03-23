using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that generates and prints to the console 10 random values in the range [100, 200].\n");

        Random randomNum = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = randomNum.Next(100, 201);
            Console.WriteLine(numbers[i]);
        }

        Console.ReadLine();
    }
}
