using System;
using System.Text.RegularExpressions;

/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
 
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */ 

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Program that extracts from given HTML file its title (if available), and its body text without the HTML tags.\n");

        //Console.WriteLine("Enter words separated by space:");
        //string input = Console.ReadLine();

        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy </a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        string title = GetTitle(input);
        string text = GetText(input);

        Console.WriteLine("Title: {0}\nText: {1}", title, text);

        Console.ReadLine();
    }

    private static string GetText(string input)
    {
        string text = Regex.Match(input, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
        return Regex.Replace(text, @"<.*?>", String.Empty);
    }

    private static string GetTitle(string input)
    {
        string head = Regex.Match(input, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
        if (head == String.Empty || !head.Contains("title"))
        {
            return string.Empty;
        }

        string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
        title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
        title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

        return title.Trim();
    }
}