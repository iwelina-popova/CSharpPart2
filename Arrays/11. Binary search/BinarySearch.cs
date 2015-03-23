using System;

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Program that finds the index of given element in a sorted array of integers.\n");

        // Вариант с готови стойности

        int n = 10;
        int[] numbers = { 1, 3, 4, 5, 7, 8, 9, 10, 18, 20 };
        //int[] numbers = { 3, 5, 6, 9, 11, 12, 15, 17, 18, 20};
        int givenElement = 9;

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //Console.WriteLine("Please enter a sorted array!");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("Choose one element: ");
        //int givenElement = int.Parse(Console.ReadLine());


        int middle = 0;
        int arrayBegin = 0;
        int arrayEnd = numbers.Length - 1;
        int index = 0;


        while (arrayEnd >= arrayBegin)
        {
            //middle = arrayBegin + ((arrayEnd - arrayBegin) / 2);
            middle = (arrayBegin + arrayEnd) / 2;

            if (givenElement < numbers[middle])
            {
                arrayEnd = middle - 1;
            }
            else if (givenElement > numbers[middle])
            {
                arrayBegin = middle + 1;
            }
            else
            {
                index = middle;
                break;
            }
        }
        Console.WriteLine("The index of searched element is: {0}", index);


        Console.ReadLine();
    }
}

