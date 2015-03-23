using System;

/* Write a program that finds the most frequent number in an array.
Example:

input	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
 */
 
class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Program that finds the most frequent number in an array.\n");

        // Вариант с готови стойности

        int n = 15;
        int[] numbers = { 2, 3, 3, 2, 2, 1, 6, 4, 8, 8, 2, 2, 2, 8, 8 };

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int counter = 1;
        int maxCount = 1;
        int maxCountValue = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    ++counter;
                }
                if (maxCount < counter)
                {
                    maxCount = counter;
                    maxCountValue = numbers[i];
                }
            }
            counter = 1;
        }

        Console.WriteLine("The most frequent number in an array is: {0} -> {1} times.", maxCountValue, maxCount);

        Console.ReadLine();
    }
}

