using System;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Program that checks if the element at given position in given array of integers is larger than its two neighbours.\n");

        int[] numbersArray = { 5, 3, 6, 7, 4, 5, 10, 9, 1 };
        //int[] numbersArray = { 1, 2, 3, 4, 5, 6 };

        //Console.Write("Please enter a length of the array of number: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbersArray = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element [{0}]: ", i);
        //    numbersArray[i] = int.Parse(Console.ReadLine());
        //}

        int firstLagrerElement = FindLargerElement(numbersArray);
        Console.WriteLine("The array is: [{0}]", string.Join(", ", numbersArray));

        if (firstLagrerElement != -1)
        {
            Console.WriteLine("The index of the first element larger than its neighbours is: {0}", firstLagrerElement);
        }
        else
        {
            Console.WriteLine("There no element larger than its neighbours.");
        }
        

        Console.ReadLine();
    }

    static int FindLargerElement(int[] numbersArray)
    {
        int largerElement = -1;
        for (int i = 1; i < numbersArray.Length - 1; i++)
        {
            if (numbersArray[i] > numbersArray[i - 1] && numbersArray[i] > numbersArray[i + 1])
            {
                largerElement = i;
                break;
            }
        }
        return largerElement;
    }
}
