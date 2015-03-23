using System;

/* Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                        result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 
 */

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Program that finds the maximal sequence of equal elements in an array.\n");
        Console.Write("Please enter size of the array: ");

        // Вариант с готови стойности

        int n = 10;
        int[] numbers = { 1, 3, 3, 3, 3, 3, 7, 7, 7, 7};

        // Вариант с ръчно въвеждане

        //int n = int.Parse(Console.ReadLine());

        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int counter = 1;
        int maxCount = 1;
        int number = 0;
        for (int i = 0; i < n - 1; i++)
        {
            counter++;

            if (numbers[i] != numbers[i + 1])
            {
                counter = 1;
            }

            if (maxCount < counter)
            {
                maxCount = counter;
                number = numbers[i];
            }
        }

        Console.Write("The maximal sequence of equal elements in an array is: {0}", number);
        for (int i = 1; i < maxCount; i++)
        {
            Console.Write(", {0}", number);
        }

        Console.ReadLine();
    }
}

