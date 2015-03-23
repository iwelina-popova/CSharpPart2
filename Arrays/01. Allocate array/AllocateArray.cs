using System;

/* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
 */

class AllocateArray
{
    static void Main()
    {
        int[] numbersArray = new int[20];

        for (int i = 0; i < 20; i++)
        {
            numbersArray[i] = i * 5;
        }
        Console.WriteLine("The obtained array is: [{0}]", string.Join(", ", numbersArray));

        Console.ReadLine();
    }
}

