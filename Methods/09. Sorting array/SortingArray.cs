using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Program that return the maximal element in a portion of array of integers starting at given index.\n");

        int[] numbersArray = { 2, 5, 8, 11, 3, 10, 4 };
        int index = 2;

        //Console.Write("Please enter a length of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbersArray = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element [{0}]: ");
        //    numbersArray[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("Please enter an index: ");
        //int index = int.Parse(Console.ReadLine());

        int maxElement = FindMaxElement(numbersArray, index);
        int[] sortedAscending = SortInAscendingArray(numbersArray);
        

        Console.WriteLine("The array is: [{0}]", string.Join(", ", numbersArray));
        Console.WriteLine("The maximal element after index {0} is: {1}", index, maxElement);
        Console.WriteLine("The array in ascending order: [{0}]", string.Join(", ", sortedAscending));
        SortInDescendingArray(numbersArray);

        Console.ReadLine();
    }

    static void SortInDescendingArray(int[] numbers)
    {
        int maxValue;
        int temp;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            maxValue = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] > numbers[maxValue])
                {
                    maxValue = j;
                }
            }
            if (maxValue != i)
            {
                temp = numbers[i];
                numbers[i] = numbers[maxValue];
                numbers[maxValue] = temp;
            }
        }
        Console.WriteLine("The array in ascending order: [{0}]", string.Join(", ", numbers));
    }

    static int[] SortInAscendingArray(int[] numbersArray)
    {
        int minValue;
        int temp;

        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            minValue = i;
            for (int j = i + 1; j < numbersArray.Length; j++)
            {
                if (numbersArray[j] < numbersArray[minValue])
                {
                    minValue = j;
                }
            }
            if (minValue != i)
            {
                temp = numbersArray[i];
                numbersArray[i] = numbersArray[minValue];
                numbersArray[minValue] = temp;
            }
        }
        return numbersArray;
    }

    static int FindMaxElement(int[] numbersArray, int index)
    {
        int maxElement = numbersArray[0];

        for (int i = index; i < numbersArray.Length; i++)
        {
            if (maxElement < numbersArray[index])
                maxElement = numbersArray[index];
        }
        return maxElement;
    }
}
