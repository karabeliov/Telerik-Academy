using System;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/03.%20Methods for example
/// 
/// Write a method that asks the user for his name and prints “Hello, <name>”
/// Write a program to test this method.
/// 
/// </summary>
class SayHello
{
    static void Main()
    {
        // Test Method
        AskUser();
    }

    private static void AskUser()
    {
        // Input
        Console.Write("How is your name: ");
        string userName = Console.ReadLine();

        // Solution
        if (userName == string.Empty)
        {
            Console.WriteLine("Please Input your name!");
            AskUser(); // recursion to valid input
            return;
        }

        // Output
        Console.WriteLine();
        Console.WriteLine("Hello {0}!", userName);        
    }
}