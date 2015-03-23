using System;
using System.Collections.Generic;

/* Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array 
is sorted in increasing order.
Print the remaining sorted array.
Example:

input	                    result
6, 1, 4, 3, 0, 3, 6, 4, 5	1, 3, 3, 4, 5
 */

class RemoveElements
{
    static void Main()
    {
        Console.WriteLine("Program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.\n");

        // Вариант с готови стойности

        int[] numbersArray = { 2, 4, 8, 1, 3, 5, 3, 7 };
        //int[] numbersArray = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        
        List<int> numbersList = new List<int>();

        int counter = 0;
        int length = 0;

        if (numbersArray.Length % 2 != 0)
        {
            length = numbersArray.Length - 3;
        }
        else length = numbersArray.Length - 2;
            

        for (int i = 0; i <= length; i += 2)
        {
            if (i == 0 && numbersArray[0] < numbersArray[1])
            {
                numbersList.Add(numbersArray[i]);
                numbersList.Add(numbersArray[i + 1]);
                ++counter;
                continue;
            }
            if (i == 0 && numbersArray[0] > numbersArray[1])
            {
                numbersList.Add(numbersArray[i + 1]);
                continue;
            }

            if (numbersArray[i] >= numbersArray[i + 1] && numbersArray[i + 1] >= numbersList[counter])
            {
                numbersList.Add(numbersArray[i + 1]);
                ++counter;
            }
            else if (numbersArray[i] <= numbersArray[i + 1] && numbersArray[i] <= numbersList[counter])
            {
                numbersList.Add(numbersArray[i + 1]);
                ++counter;
            }         

        }

        if (numbersArray.Length % 2 != 0)
        {
            numbersList.Add(numbersArray[numbersArray.Length - 1]);
        }

        Console.Write("Sorted array: ");
        foreach (int number in numbersList)
        {
            Console.Write("{0} ", number);
        }

        Console.ReadLine();
    }
}

