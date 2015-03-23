using System;

/* Write a program that finds the sequence of maximal sum in given array.
Example:

input	                            result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?
 */ 

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Program that finds the sequence of maximal sum in given array.\n");

        // Вариант с готови стойности

        int n = 10;
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //int[] numbers = { 4, 1, -6, 2, 3, 4, -1, 2, -7, 1};

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int maxSum = 0; ;
        int currentSum = 0;
        int firstElement = 0; ;
        int lastElement = 0;

        for (int i = 1; i < n; i++)
        {
            if (currentSum <= 0)
            {
                firstElement = i;
                currentSum = 0;
            }

            currentSum += numbers[i];

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                lastElement = i;
            }
        }
        Console.Write("The sequence of maximal sum is: {0}", numbers[firstElement]);
        for (int i = firstElement + 1; i <= lastElement; i++)
        {
            Console.Write(", {0}", numbers[i]);
        }


        Console.ReadLine();
    }
}

