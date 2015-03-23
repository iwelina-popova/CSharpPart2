using System;

// Write a program that sorts an array of integers using the Quick sort algorithm.

class QuickSortAlgoritm
{
    static void Main()
    {
        Console.WriteLine("Program that sorts an array of integers using the Quick sort algorithm.\n");

        // Вариант с готови стойности

        int[] numbers = { 2, 4, 8, 1, 3, 5, 7, 6 };

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        Console.WriteLine("The array before sorting: {0}", string.Join(",", numbers));

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("The array after sorting: {0}", string.Join(",", numbers));

        Console.ReadLine();
    }

    static void QuickSort(int[] numbersArray, int left, int right)
    {
        int tempLeft = left;
        int tempRight = right;
        int pivot = numbersArray[(left + right) / 2];

        while (tempLeft < tempRight)
        {
            while (pivot > numbersArray[tempLeft])
            {
                ++tempLeft;
            }
            while (pivot < numbersArray[tempRight])
            {
                --tempRight;
            }
            if (tempLeft <= tempRight)
            {
                int temp = numbersArray[tempLeft];
                numbersArray[tempLeft] = numbersArray[tempRight];
                numbersArray[tempRight] = temp;
                ++tempLeft;
                --tempRight;
            }
        }
        if (left < tempRight) QuickSort(numbersArray, left, tempRight);
        if (right > tempLeft) QuickSort(numbersArray, tempLeft, right);
    }

}

