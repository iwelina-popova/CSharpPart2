using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaximaSum
{
    static void Main()
    {
        Console.WriteLine("Program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.\n");

        int[,] matrix = { 
                        { 0, 5, 10, 15, 9, 5, 1, 9 },
                        { 3, 6, 12, 18, 2, 1, 4, 0 },
                        { 1, 7, 14, 21, 5, 6, 8, 10 },
                        { 4, 1, 7, 9, 1, 0, 5, 3 }
                        };


        //Console.Write("Please enter a number of rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Please enter a number of columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[rows, cols];
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("Element [{0}, {1}]: ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        int maxSum = 0;
        int bestCol = 0;
        int bestRow = 0;

        for (int row = 0; row < matrix.GetLength(0) - 3; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 3; col++)
            {
                int currentSum = 0;

                for (int currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        currentSum += matrix[currentRow, currentCol];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

