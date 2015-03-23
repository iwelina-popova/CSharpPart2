using System;


/* 
Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)		
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
 
b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
  
c) 
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
  
d)*  
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
 */
class FillMatrix
{
    static void Main()
    {
        Console.WriteLine("Program that fills and prints a matrix of size (n, n).\n");

        Console.Write("Please enter a value of n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        // Вариант А)

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = number;
                ++number;
            }
        }

        Console.WriteLine("\nA)");
        PrintMatrix(matrix, n);

        // Вариант Б)

        number = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = number;
                    ++number;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    ++number;
                }
            }
        }

        Console.WriteLine("\nB)");
        PrintMatrix(matrix, n);

        // Вариант С)

        number = 1;

        for (int row = n - 1; row > 0; row--)
            {
                int tempRow = row;

                for (int col = 0; col < n - row; col++)
                {
                    matrix[tempRow, col] = number;
                    ++number;
                    ++tempRow;
                }
            }

        for (int col = 0; col < n; col++)
            {
                int tempCol = col;
                for (int row = 0; row < n - col; row++)
                {
                    matrix[row, tempCol] = number;
                    ++number;
                    tempCol++;
                }
            }
        
        Console.WriteLine("\nC)");
        PrintMatrix(matrix, n);


        // Вариант D)

        number = 1;
        int line = 0;
        int column = 0;
        int firstIndex = 0;
        int lastIndex = n - 1;

        while (lastIndex > 0)
        {
            for (line = firstIndex; line <= lastIndex; line++)
            {
                matrix[line, column] = number;
                ++number;
            }
            ++firstIndex;
            --line;
            for (column = firstIndex; column <= lastIndex; column++)
            {
                matrix[line, column] = number;
                ++number;
            }
            --lastIndex;
            --column;

            for (line = lastIndex; line >= firstIndex - 1; line--)
            {
                matrix[line, column] = number;
                ++number;
            }
            ++line;
            for (column = lastIndex; column >= firstIndex; column--)
            {
                matrix[line, column] = number;
                ++number;
            }
            ++column;
        }
        

        Console.WriteLine("\nD)");
        PrintMatrix(matrix, n);

        Console.ReadLine();
    }

    static void PrintMatrix(int[,] numbersArray, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", numbersArray[row, col]);
            }
            Console.WriteLine();
        }
    }
}

