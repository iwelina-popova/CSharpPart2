using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Program that compares two char arrays lexicographically (letter by letter).\n");
        Console.Write("Please enter size of the first array: ");

        //     Вариант 1 - готов масив

        char[] firstCharArray = { 'a', 'b', 'd', 't', 'r' }; // {'z', 't', 'r', 'j'};
        char[] secondCharArray = { 'a', 't', 'd' };          // {'a', 'b', 'c'}
        int n = firstCharArray.Length;
        bool isEqual = false;
        int length = firstCharArray.Length;
        if (secondCharArray.Length < firstCharArray.Length)
        {
            length = secondCharArray.Length;
        }

        string[] equalLetters = new string[length];
        int count = 0;

        for (int i = 0; i < length; i++)
        {
            if (firstCharArray[i] == secondCharArray[i])
            {
                isEqual = true;
                equalLetters[count] += firstCharArray[i];
                count++;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("\nThe equal letters are: {0}", string.Join(" ", equalLetters));
        }
        else
        {
            Console.WriteLine("\nThere aren't equal letters!");
        }
        
        //     Вариант 2 - въвеждане от конзолата

        //int n = int.Parse(Console.ReadLine());
        //char[] firstCharArray = new char[n];
        
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    firstCharArray[i] = char.Parse(Console.ReadLine());
        //}

        //Console.Write("Please enter size of the second array: ");
        //int m = int.Parse(Console.ReadLine()); 
        //char[] secondCharArray = new char[m];

        //for (int i = 0; i < m; i++)
        //{
        //    Console.Write("Element {0}: ", i);
        //    secondCharArray[i] = char.Parse(Console.ReadLine());
        //}
        

        //bool isEqual = false;
        //int length = firstCharArray.Length;
        //if (secondCharArray.Length < firstCharArray.Length)
        //{
        //    length = secondCharArray.Length;
        //}

        //string[] equalLetters = new string[length];
        //int count = 0;

        //for (int i = 0; i < length; i++)
        //{
        //    if (firstCharArray[i] == secondCharArray[i])
        //    {
        //        isEqual = true;
        //        equalLetters[count] += firstCharArray[i];
        //        count++;
        //    }
        //}

        //if (isEqual)
        //{
        //    Console.WriteLine("The equal letters are: {0}", string.Join(" ", equalLetters));
        //}
        //else
        //{
        //    Console.WriteLine("There aren't equal letters!");
        //}


        Console.ReadLine();        
    }
}

