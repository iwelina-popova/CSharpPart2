using System;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class SortString
{
    static void Main()
    {
        string[] stringsArray = { 
                                "am",
                                "I",
                                "hungry",
                                "very"
                                };

        string[] sortedString = SortByLength(stringsArray);

        Console.WriteLine("Sorted by the length of the elements: {0}", string.Join(" ", sortedString));

        Console.ReadLine();
    }

    static string[] SortByLength(string[] stringArray)
    {
        int smallerString = 0;
        string temp = "";

        for (int i = 0; i < stringArray.Length - 1; i++)
        {
            smallerString = i;
            for (int j = i + 1; j < stringArray.Length; j++)
            {
                if (stringArray[j].Length < stringArray[i].Length)
                {
                    smallerString = j;
                }
            }
            if (smallerString != i)
            {
                temp = stringArray[i];
                stringArray[i] = stringArray[smallerString];
                stringArray[smallerString] = temp;
            }
        }
        return stringArray;
    }
}

