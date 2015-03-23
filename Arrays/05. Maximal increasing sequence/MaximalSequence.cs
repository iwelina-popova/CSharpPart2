using System;

/* Write a program that finds the maximal increasing sequence in an array.
Example:

input	                result
3, 2, 3, 4, 2, 2, 4	    2, 3, 4
 */ 

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Program that finds the maximal increasing sequence in an array.\n");

        // Вариант с готови стойности

        int n = 10;
        int[] numbers = { 1, 3, 2, 3, 4, 5, 6, 4, 5, 6 };

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int lastNumber = 0;
        int counter = 1;
        int maxCount = 0;

        for (int i = 0; i < n - 1; i++)
        {
            ++counter;
            if (numbers[i] + 1 != numbers[i + 1])
            {
                counter = 1;
            }
            if (maxCount < counter)
            {
                maxCount = counter;
                lastNumber = numbers[i + 1];
            }
        }

        int firstNumber = lastNumber - maxCount + 1;
        for (int i = firstNumber; i <= lastNumber; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.ReadLine();
    }
}

