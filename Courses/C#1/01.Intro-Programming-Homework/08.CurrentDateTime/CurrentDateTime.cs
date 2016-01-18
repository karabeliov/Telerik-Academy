using System;
/// <summary>
/// 
/// Create a console application that prints the current date and time.
/// 
/// </summary>
class CurrentDateTime
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine(currentDateTime);
    }
}