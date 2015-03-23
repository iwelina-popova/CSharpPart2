using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class EnterNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100\n");

        int start = 1;
        int end = 100;

        try
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = RealNumber(start, end);

                if (i > 0)
                {
                    while (numbers[i] <= numbers[i - 1])
                    {
                        Console.WriteLine("The number should be bigger than the previous one.");
                        numbers[i] = RealNumber(start, end);
                    }
                }                
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is not in the correct range [{0} - {1}]", start, end);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The number doesn't have value.");
        }

        Console.ReadLine();
    }

    static int RealNumber(int start, int end)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if(number < start || number > end)
            throw new ArgumentOutOfRangeException();

        if(number == null)
            throw new ArgumentNullException();

        return number;
    }

}