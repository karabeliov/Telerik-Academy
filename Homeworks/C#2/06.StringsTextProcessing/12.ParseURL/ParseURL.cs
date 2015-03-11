using System;
/// <summary>
/// 
/// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
/// 
/// </summary>
class ParseURL
{
    static void Main()
    {
        // Input
        Console.Write("Enter URL address: ");
        string url = Console.ReadLine();

        // Protocol
        int indexProtocol = url.IndexOf(':');
        string protocol = url.Substring(0, indexProtocol);

        // Server
        int indexServer = url.IndexOf("//") + 2;
        int indexEndServer = url.IndexOf("/",indexServer);
        string server = url.Substring(indexServer, indexEndServer - indexServer);

        // Resource
        int resourceIndex = indexEndServer;
        string resource = url.Substring(resourceIndex);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}