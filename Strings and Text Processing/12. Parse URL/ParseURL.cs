using System;

/* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	                                                    Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
                                                        [server] = telerikacademy.com 
                                                        [resource] = /Courses/Courses/Details/212
 */ 

class ParseURL
{
    static void Main()
    {
        Console.WriteLine(@"Program that parses an URL address given in the format: [protocol]://[server]/[resource] 
                           and extracts from it the [protocol], [server] and [resource] elements.");

        string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        Console.WriteLine("Information about the URL address: ");
        Console.WriteLine("[protocol] = {0}", GetProtocol(url));
        string server = GetServer(url);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", GetResouce(url, server));

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