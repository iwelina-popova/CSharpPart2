using System;
using System.Text;

/* Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input
<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. 
 Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
 
 output
 <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
 * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */ 

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine(@"Program that replaces in a HTML document given as string all the tags 
<a href=""…"">…</a> with corresponding tags [URL=…]…/URL].");
        Console.WriteLine();

        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        StringBuilder builder = new StringBuilder(input);

        builder = builder.Replace("<a href=\"", "[URL=");
        builder = builder.Replace("\">", "]");
        builder = builder.Replace("</a>", "[/URL]");

        Console.WriteLine(builder.ToString());
        Console.ReadLine();
    }

    private static string GetResouce(string url, string server)
    {
        string resource = String.Empty;

        int resourceStart = url.IndexOf('/', server.Length);

        resource = url.Substring(resourceStart);

        return resource;
    }

    private static string GetServer(string url)
    {
        string server = String.Empty;

        int serverBegin = url.IndexOf("//") + 2;
        int serverEnd = url.IndexOf("/", serverBegin);

        server = url.Substring(serverBegin, serverEnd - serverBegin);

        return server;
    }

    private static string GetProtocol(string url)
    {
        string protocol = String.Empty;

        int protocolEnd = url.IndexOf(':');
        protocol = url.Substring(0, protocolEnd);

        return protocol;
    }
}
