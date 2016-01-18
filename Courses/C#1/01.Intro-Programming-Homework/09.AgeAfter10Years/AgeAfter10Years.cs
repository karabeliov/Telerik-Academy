using System;
/// <summary>
/// 
/// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
/// 
/// </summary>
class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday in this format | 26.10.1993 |");
        string userBirthday = Console.ReadLine();
        DateTime date = DateTime.Parse(userBirthday);
        int userOld = DateTime.Now.Year;
        userOld -= date.Year;
        if (DateTime.Today.Month < date.Month)
        {
            userOld -= 1;
        }
        Console.WriteLine();
        Console.WriteLine("Now you are {0} years old.", userOld);
        Console.WriteLine("After 10 years you will be {0} years old.", (userOld + 10));
    }
}