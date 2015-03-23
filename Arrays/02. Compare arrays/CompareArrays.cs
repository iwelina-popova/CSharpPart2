using System;

// Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Program that reads two integer arrays from the console and compares them element by element.\n");
        Console.Write("Please enter size of the first array: ");
        
        int n = int.Parse(Console.ReadLine());
        // int n = 6; 
        // int[] firstArray = { 1, 5, 9, 8, 7, 4 };
        int[] firstArray = new int[n]; 

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter size of the second array: ");
        int m = int.Parse(Console.ReadLine());        
        int[] secondArray = { 1, 2, 3, 9, 6, 4 };
        // int m = 6; 
        // int[] secondArray = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write("Element {0}: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        int minLength = n;
        bool isEqual = false;
        

        if (m < n)
        {
            minLength = m;
        }

        int[] equalNumbers = new int[minLength];
        int count = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                isEqual = true;
                equalNumbers[count] += firstArray[i];
                count++;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("The equal elements are: {0}", string.Join(", ", equalNumbers));
        }
        else
        {
            Console.WriteLine("There aren't equal numbers!");
        }
        Console.ReadLine();
    }
}

