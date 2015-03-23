using System;
using System.Linq;
using System.Collections.Generic;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K.

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Program, that reads from the console an array of N integers and an integer K and sorts the array.\n");

        Console.Write("Please enter a number of elements N: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter an integer K: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(numbersArray);
        if (numbersArray[0] > k)
            Console.WriteLine("All number in the array are bigger than {0}!", k);
        else
        {
            int index = Array.BinarySearch(numbersArray, k);
            if (index >= 0)
                Console.WriteLine("There is equal number {0} = {1}", numbersArray[index], k);
            else
            {
                index = Math.Abs(index) - 2;
                Console.WriteLine("This is the largest number {0} < {1}", numbersArray[index], k);
            }
        }

        Console.ReadLine();
    }
}

