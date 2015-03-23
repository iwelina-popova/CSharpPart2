using System;
using System.Collections.Generic;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter a number of the integers you'll input: ");
        int counter = int.Parse(Console.ReadLine());

        int[] numbers = new int[counter];

        for (int i = 0; i < counter; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Min: {0}", Min(numbers));
        Console.WriteLine("Max: {0}", Max(numbers));
        Console.WriteLine("Average: {0}", Average(numbers));
        Console.WriteLine("Sum: {0}", Sum(numbers));
        Console.WriteLine("Product: {0}", Product(numbers));
    }

    static int Product(params int[] sequence)
    {
        int product = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static int Sum(int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static double Average(int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / sequence.Length;
    }

    static int Max(int[] sequence)
    {
        int maxValue = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > maxValue)
            {
                maxValue = sequence[i];
            }
        }
        return maxValue;
    }

    static int Min(int[] sequence)
    {
        int minValue = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < minValue)
            {
                minValue = sequence[i];
            }
        }
        return minValue;
    }
}