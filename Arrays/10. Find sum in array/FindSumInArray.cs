using System;

/* Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	               S	 result
4, 3, 1, 4, 2, 5, 8	   11	 4, 2, 5
 */ 

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Program that finds in given array of integers a sequence of given sum S (if present).\n");

        // Вариант с готови стойности

        int n = 8;
        int[] numbers = { 2, 4, 8, 1, 3, 5, 3, 7 };
        int sum = 11;

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("The sum S = ");
        //int sum = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int firstIndex = 0;
        int lastIndex = 0;

        for (int i = 0; i < n; i++)
        {
            currentSum = numbers[i];
            for (int j = i + 1; j < n; j++)
            {
                currentSum += numbers[j];
                if (currentSum == sum)
                {
                    firstIndex = i;
                    lastIndex = j;
                    continue;
                }
                if (currentSum > sum) break;
            }
        }
        Console.Write("The sequence is: {0}", numbers[firstIndex]);
        for (int i = firstIndex + 1; i <= lastIndex; i++)
        {
            Console.Write(", {0}", numbers[i]);
        }

        Console.ReadLine();
    }
}

