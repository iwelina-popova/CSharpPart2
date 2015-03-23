using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Program that sort an array.\n");

        // Вариант с готови стойности

        int n = 10;
        int[] numbers = { 3, 8, 4, 5, 9, 2, 0, 6, 1, 7 };

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int minValue;
        int temp;

        for (int i = 0; i < n - 1; i++)
        {
            minValue = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minValue])
                {
                    minValue = j;
                }
            }
            if (minValue != i)
            {
                temp = numbers[i];
                numbers[i] = numbers[minValue];
                numbers[minValue] = temp;
            }
        }
        Console.WriteLine("The sorted array is: [{0}]", string.Join(", ", numbers));

        Console.ReadLine();
    }
}

