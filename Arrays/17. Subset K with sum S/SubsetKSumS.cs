using System;

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

class SubsetKSumS
{
    static void Main()
    {
        Console.WriteLine("Program that reads three integer numbers N, K and S and an array of N elements from the console.\n");

        // Вариант с готови стойности

        //int[] numbers = { 2, 4, 8, 1, 3, 5, 3, 7 };
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int numberOfElements = 3;
        int sum = 14;

        // Вариант с ръчно въвеждане

        //Console.Write("Please enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("The sum S = ");
        //int sum = int.Parse(Console.ReadLine());
        //Console.Write("The number of elements K = ");
        //int numberOfElements = int.Parse(Console.ReadLine());

        long currentSum = 0;
        int counter = 0;
        int countElements = 0;
        int maximalSubset = (int)Math.Pow(2, numbers.Length - 1);
        string currentSubset = "";

        for (int i = 1; i < maximalSubset; i++)
        {
            currentSubset = "";
            currentSum = 0;
            countElements = 0;

            for (int j = 0; j <= numbers.Length - 1; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    ++countElements;
                    currentSum += numbers[j];
                    if (string.IsNullOrEmpty(currentSubset)) currentSubset += numbers[j];
                    else currentSubset = currentSubset + " + " + numbers[j];
                }
            }
            if (currentSum == sum && countElements == numberOfElements)
            {
                counter++;
                Console.WriteLine("The subset of:  {0} = {1} ", currentSubset, sum);
            }
        }
        if (counter != 0) Console.WriteLine("\nThe subsets of the elements of the array that has a sum S = {0} are: {1}", sum, counter);
        else Console.WriteLine("\nThere no  subset of the elements of the array that has a sum S = {0}", sum, counter);

        Console.ReadLine();
    }
}

