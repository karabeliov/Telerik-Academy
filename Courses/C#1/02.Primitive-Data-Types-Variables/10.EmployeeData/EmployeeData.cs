using System;
/// <summary>
/// 
/// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
/// First namе
/// Last name
/// Age (0...100)
/// Gender (m or f)
/// Personal ID number (e.g. 8306112507)
/// Unique employee number (27560000…27569999)
/// Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
/// Use descriptive names. Print the data at the console.
/// 
/// </summary>
class EmployeeData
{
    static void Main()
    {
        string firstName = "Kristian";
        string lastName = "Karabeliov";
        byte age = 21;
        char gender = 'm';
        long personalID = 8306112507;
        int uniqueEmployeeNumber = 27569999;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personalID);
        Console.WriteLine("Unique employee number: " + uniqueEmployeeNumber);
    }
}