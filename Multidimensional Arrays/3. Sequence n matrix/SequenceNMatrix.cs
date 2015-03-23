using System;

/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	               result		
ha	fifi ho	hi        
fo	ha	 hi	xx        ha, ha, ha
xxx	ho	 ha	xx
	
 
matrix	         result
s	qq	s
pp	pp	s        s, s, s
pp	qq	s

 */

class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("Program that finds the longest sequence of equal strings in the matrix.\n");

        string[,] matrix = { 
                        { "ha", "hi", "ho", "hi" },
                        { "ho", "oh", "hi", "xx" },
                        { "xxx", "hii", "ha", "hi" },
                        { "xxx", "tt", "ho", "ha" },
                        };

        //string[,] matrix = { 
        //                { "ha", "fifi", "ho", "hi" },
        //                { "fo", "ho", "hi", "xx" },
        //                { "ho", "oh", "oh", "xx" },
        //                };

        //string[,] matrix = { 
        //                { "s", "qq", "s" },
        //                { "pp", "pp", "s" },
        //                { "pp", "qq", "s" },
        //                };

        // Вариант с ръчно въвеждане:

        //Console.Write("Please enter a number of rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Please enter a number of columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //string[,] matrix = new string[rows, cols];
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("Element [{0}, {1}]: ", row, col);
        //        matrix[row, col] = Console.ReadLine();
        //    }
        //}


        // Проверка на ред:

        int longestSequence = 0;
        int currentSequence = 1;
        string equalElement = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            currentSequence = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] != matrix[row, col + 1])
                {
                    currentSequence = 1;
                }
                else
                {
                    ++currentSequence;
                    if (longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        equalElement = matrix[row, col];
                    }
                }
            }
        }


        // Проверка на колона:

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            currentSequence = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] != matrix[row + 1, col])
                {
                    currentSequence = 1;
                }
                else
                {
                    ++currentSequence;
                    if (longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        equalElement = matrix[row, col];
                    }
                }
            }
        }

        // Проверка на главен диагонал:

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int tempRow = row;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSequence = 1;
                int tempCol = col;
                while (tempRow < matrix.GetLength(0) - 1 - col)
                {
                    if (matrix[tempRow, tempCol] != matrix[tempRow + 1, tempCol + 1])
                    {
                        currentSequence = 1;
                        break;
                    }
                    else
                    {
                        ++currentSequence;
                        if (longestSequence < currentSequence)
                        {
                            longestSequence = currentSequence;
                            equalElement = matrix[tempRow, tempCol];
                        }
                    }
                    ++tempRow;
                    ++tempCol;
                }
            }
        }

        // Проверка на втори диагонал:

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int tempRow = row;
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                tempRow = row;
                currentSequence = 1;
                int tempCol = col;
                while (tempRow < matrix.GetLength(0) - 1)
                {
                    if (matrix[tempRow, tempCol] != matrix[tempRow + 1, tempCol - 1])
                    {
                        currentSequence = 1;
                        break;
                    }
                    else
                    {
                        ++currentSequence;
                        if (longestSequence < currentSequence)
                        {
                            longestSequence = currentSequence;
                            equalElement = matrix[tempRow, tempCol];
                        }
                    }
                    ++tempRow;
                    --tempCol;
                }
            }
        }

        string[] printLongestSequence = new string[longestSequence];
        for (int i = 0; i < longestSequence; i++)
        {
            printLongestSequence[i] = equalElement;
        }
        Console.WriteLine("The longest sequence is: [{0}]", string.Join(", ", printLongestSequence));

        Console.ReadLine();
    }
}

