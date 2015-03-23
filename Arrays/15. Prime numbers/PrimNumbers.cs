using System;

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class PrimNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.\n");

        bool[] isPrimeNumber = new bool[10000]; // 10 000 000 is too big for the console's buffer
        int sqrtLength = (int)Math.Sqrt(isPrimeNumber.Length);

        for (int i = 2; i < sqrtLength; i++)
        {
            if (!isPrimeNumber[i])
            {
                for (int j = i * i; j < isPrimeNumber.Length; j += i)
                {
                    isPrimeNumber[j] = true;
                }
            }
            
        }
        Console.Write("The prime numbers are:\n");

        for (int i = 1; i < isPrimeNumber.Length; i++)
        {
            if (!isPrimeNumber[i]) Console.Write("{0} ", i);
        }


        Console.ReadLine();
    }
}

