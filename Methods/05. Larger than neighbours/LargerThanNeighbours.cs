using System;

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Program that checks if the element at given position in given array of integers is larger than its two neighbours.\n");

        int[] numbersArray = { 5, 8, 6, 5, 4, 5 };
        int positionElement = 1;

        
        //Console.Write("Please enter a length of the array of number: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] numbersArray = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element [{0}]: ", i);
        //    numbersArray[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("Please enter a position of an element: ");
        //int positionElement = int.Parse(Console.ReadLine());

        Console.WriteLine("The array is: [{0}]", string.Join(", ", numbersArray));
        IsElementLarger(numbersArray, positionElement);
        Console.ReadLine();
    }

    static void IsElementLarger(int[] numbersArray, int positionElement)
    {
        if (positionElement > 0 && positionElement < numbersArray.Length - 1)
        {
            if (numbersArray[positionElement - 1] < numbersArray[positionElement] &&
            numbersArray[positionElement] > numbersArray[positionElement + 1])
                Console.WriteLine("The element [{0}]: {1} is larger than its two neighbours {2} and {3}",
                                         positionElement, numbersArray[positionElement], numbersArray[positionElement - 1], numbersArray[positionElement + 1]);
            else Console.WriteLine("The element [{0}]: {1} is not larger than its two neighbours {2} and {3}",
                                          positionElement, numbersArray[positionElement], numbersArray[positionElement - 1], numbersArray[positionElement + 1]);
        }
        else if (positionElement == 0)
        {
            if (numbersArray[positionElement] > numbersArray[positionElement + 1])
                Console.WriteLine("The element [{0}]: {1} is larger than its rigth neighbour {2}",
                                         numbersArray[positionElement], positionElement, numbersArray[positionElement + 1]);
            else Console.WriteLine("The element [{0}]: {1} is not larger than its rigth neighbour {2}",
                                         positionElement, numbersArray[positionElement], numbersArray[positionElement + 1]);
        }
        else if(positionElement == numbersArray.Length - 1)
        {
            if (numbersArray[positionElement] > numbersArray[positionElement - 1])
                Console.WriteLine("The element [{0}]: {1} is larger than its left neighbour {2}",
                                          positionElement, numbersArray[positionElement], numbersArray[positionElement - 1]);
            else Console.WriteLine("The element [{0}]: {1} is not larger than its letf neighbour {2}",
                                          positionElement, numbersArray[positionElement], numbersArray[positionElement - 1]);
        }
        else Console.WriteLine("There no element at this position");
    }
}
