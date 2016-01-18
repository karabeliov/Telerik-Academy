using System;
/// <summary>
/// 
/// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
/// If the variable is int or double, the program increases it by one.
/// If the variable is a string, the program appends * at the end.
/// Print the result at the console. 
/// 
/// </summary>
class PlayIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
        byte choose = byte.Parse(Console.ReadLine());

        switch (choose)
        {
            case 1: Console.Write("Please enter a int: ");
                int chooseInt = int.Parse(Console.ReadLine());
                Console.WriteLine(chooseInt + 1);
                break;
            case 2: Console.Write("Please enter a double: ");
                double chooseDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(chooseDouble + 1);
                break;
            case 3: Console.Write("Please enter a string: ");
                string chooseString = Console.ReadLine();
                Console.WriteLine(chooseString + '*');
                break;
            default: Console.WriteLine("This is not correct choose!!!");
                break;
        }
    }
}