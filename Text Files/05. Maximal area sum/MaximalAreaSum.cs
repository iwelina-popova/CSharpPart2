using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/* Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	   output
4 
2 3 3 4    17
0 2 3 4 
3 7 1 2 
4 3 3 2	
 */

class MaximalAreaSum
{
    static void Main()
    {
        Console.WriteLine("Program that reads a text file containing a square matrix of numbers.\n");

        using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
        {
            long size = long.Parse(reader.ReadLine());
            long[,] matrix = new long[size, size];

            for (int row = 0; row < size; row++)
            {
                string[] line = reader.ReadLine().Split(' ');

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            WriteMaxSumToFile(FindMaxSum(matrix));
        }
    }

    private static void WriteMaxSumToFile(long sum)
    {
        using (StreamWriter writer = new StreamWriter("..\\..\\output.txt"))
        {
            writer.WriteLine(sum);
        }
    }

    private static long FindMaxSum(long[,] matrix)
    {
        long maxSum = long.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                long temp = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (temp > maxSum)
                {
                    maxSum = temp;
                }
            }
        }

        return maxSum;
    }
}
