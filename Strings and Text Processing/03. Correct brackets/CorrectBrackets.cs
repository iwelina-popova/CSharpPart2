using System;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Program to check if in a given expression the brackets are put correctly.\n");

        string input = "((a+(b * 6))/(50-(d(a+5))*4))";
        //string input = "(a+(b * 6))/5";
        //string input = ")(a+b))";

        //Console.Write("Enter an expression: ");
        //string input = Console.ReadLine();

        int openedBrackets = 0;
        int closedBrackets = 0;
        bool isCorrect = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
                ++openedBrackets;
            else if (input[i] == ')')
                ++closedBrackets;

            if (closedBrackets > openedBrackets)
                break;
        }

        if(openedBrackets == closedBrackets)
        {
            isCorrect = true;
            Console.WriteLine("The brackets are put correctly. - {0}", isCorrect);
        }            
        else
            Console.WriteLine("The brackets are put correctly. - {0}", isCorrect);

        Console.ReadLine();
    }
}
