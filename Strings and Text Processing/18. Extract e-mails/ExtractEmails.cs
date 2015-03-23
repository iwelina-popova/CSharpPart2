using System;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Program for extracting all email addresses from given text.\n");

        //Console.Write("Enter email: ");
        //string email = Console.ReadLine();

        string input = "I have two emails: pesho.peshov@mail.com and pesho_peshov@gmail.com";

        string[] splitted = input.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);

        string validEmail = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
          @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";
        
        foreach (var email in splitted)
        {
            if(Regex.IsMatch(email, validEmail))
                Console.WriteLine(email);
        }
               

        Console.ReadLine();
    }
}
