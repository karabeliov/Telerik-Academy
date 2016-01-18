using System;
/// <summary>
/// 
/// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
/// Write a program that reads the information about a company and its manager and prints it back on the console.
/// 
/// </summary>
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string fax = Console.ReadLine();
        string webSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        if (fax.Length < 5)
        {
            fax = "(no fax)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,managerPhone);
    }
}