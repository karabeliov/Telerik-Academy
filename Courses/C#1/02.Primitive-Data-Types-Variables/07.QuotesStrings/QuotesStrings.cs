using System;
/// <summary>
/// 
/// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
/// Do the above in two different ways - with and without using quoted strings.
/// Print the variables to ensure that their value was correctly defined.
/// 
/// </summary>
class QuotesStrings
{
    static void Main()
    {
        string quited = "The \"use\" of quotations causes difficulties";
        string quitedString = @"The ""use"" of quotations causes difficulties";

        Console.WriteLine("{0}\n{1}", quited, quitedString);
    }
}