using System;
using System.Linq;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

class NFactorial
{
    static void Main()
    {
        Console.WriteLine("Program that calculate n! for each n in the range [1..100].\n");

        BigInteger[] factorial = new BigInteger[100];
        factorial[0] = 1;

        for (int i = 1; i < factorial.Length; i++)
        {
            factorial[i] = MultiplyNumber(factorial[i - 1], i);
            Console.WriteLine(factorial[i]);
        }

        Console.ReadLine();
    }

    static BigInteger MultiplyNumber(BigInteger product,int number)
    {
        BigInteger currentProduct = product * number;
        return currentProduct;
    }

    
}
