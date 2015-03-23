using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Program that reads two integer numbers N and K and an array of N elements from the console.\n");

        // Вариант 1 - с готови стойности 

        int N = 10;
        int K = 4;
        int[] numbers = { 2, 5, 15, 8, 4, 6, 11, 1, 3, 9};

        // Вариант 2 - с ръчно въвеждане

        //Console.Write("Please enter first integer number N = ");
        //int N = int.Parse(Console.ReadLine());
        //Console.Write("Please enter second integer number K = ");
        //int K = int.Parse(Console.ReadLine());
        //int[] numbers = new int[N];

        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int maxValue;
        int temp;

        for (int i = 0; i < K; i++)
        {
            maxValue = i;
            for (int j = i + 1; j < N; j++)
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

        int sum = 0;
        Console.Write("The elements that have maximal sum are: ");
        for (int i = 0; i < K; i++)
        {
            sum += numbers[i];
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine("\nThe sum is: {0}", sum);

        Console.ReadLine();
    }
}

