using System;

// Write a program that sorts an array of integers using the Merge sort algorithm.

class MergeSort
{
    static void Main()
    {
        Console.WriteLine("Program that sorts an array of integers using the Merge sort algorithm.\n");

        // Вариант с готови стойности

        int n = 10;
        //int[] numbers = { 2, 4, 8, 1, 3, 5, 7, 6, 15, 0 };
        int[] numbers = { 8, 6, 4, 15, 2, 3, 7, 11, 9, 5 };

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

        int[] tempArray = new int[n];

        TopDownSplitMerge(numbers, 0, numbers.Length, tempArray);

        Console.WriteLine("The array after sorting: {0}", string.Join(",", numbers));

        Console.ReadLine();
    }

    static void TopDownSplitMerge(int[] sortNumbers, int begin, int end, int[] temp)
    {
        if (end - begin < 2) return;

        int middle = begin + ((end - begin) / 2);

        TopDownSplitMerge(sortNumbers, begin, middle, temp);
        TopDownSplitMerge(sortNumbers, middle, end, temp);
        TopDownMerge(sortNumbers, begin, middle, end, temp);
        CopyArray(temp, begin, end, sortNumbers);
    }

    static void TopDownMerge(int[] sortNumbers, int begin, int middle, int end, int[] temp)
    {
        int first = begin;
        int last = middle;

        for (int i = begin; i < end; i++)
        {
            if (first < middle && (last >= end || sortNumbers[first] <= sortNumbers[last]))
            {
                temp[i] = sortNumbers[first];
                ++first;
            }
            else
            {
                temp[i] = sortNumbers[last];
                ++last;
            }

        }
    }

    static void CopyArray(int[] temp, int begin, int end, int[] sortNumbers)
    {
        for (int i = begin; i < end; i++)
        {
            sortNumbers[i] = temp[i];
        }
    }

}

