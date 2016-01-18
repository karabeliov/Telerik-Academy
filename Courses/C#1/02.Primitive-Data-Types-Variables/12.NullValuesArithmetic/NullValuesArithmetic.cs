using System;
/// <summary>
/// 
/// Create a program that assigns null values to an integer and to a double variable.
/// Try to print these variables at the console.
/// Try to add some number or the null literal to these variables and print the result.
/// 
/// </summary>
class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("int = " + nullInt);
        Console.WriteLine("double = " + nullDouble);

        nullInt = 5;
        nullDouble = null;
        Console.WriteLine();
        Console.WriteLine("int = " + nullInt);
        Console.WriteLine("double = " + nullDouble);
    }
}