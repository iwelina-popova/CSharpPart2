using System;

/* We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:

input array	              S	     result
2, 1, 2, 4, 3, 5, 2, 6	  14	 yes
 */ 

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Program to find if there exists a subset of the elements of the array that has a sum S.\n");

        // Вариант с готови стойности

        //int[] numbers = { 2, 4, 8, 1, 3, 5, 3, 7 };
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };       
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

        long currentSum = 0;
        int counter = 0;
        int maximalSubset = (int)Math.Pow(2, numbers.Length - 1);
        string currentSubset = "";

        for (int i = 1; i < maximalSubset; i++)
        {
            currentSubset = "";
            currentSum = 0;

            for (int j = 0; j <= numbers.Length - 1; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                    if (string.IsNullOrEmpty(currentSubset)) currentSubset += numbers[j];
                    else currentSubset = currentSubset + " + " + numbers[j];                    
                }
            }
            if (currentSum == sum)
            {
                counter++;
                Console.WriteLine("The subset of:  {0} = {1} ", currentSubset, sum);
            }
        }

        Console.WriteLine("\nThe subsets of the elements of the array that has a sum S = {0} are: {1}", sum, counter);

        Console.ReadLine();
    }
}

