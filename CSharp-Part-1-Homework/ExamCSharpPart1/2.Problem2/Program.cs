using System;

class Program
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0; 

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                break;
            }
            else if (char.IsDigit(text[i]))
            {
                result *= int.Parse(text[i].ToString());
            }
            else if (char.IsSymbol(text[i]) || char.IsPunctuation(text[i]) || char.IsSeparator(text[i]))
            {
                result = result % M;
            }
            else if (char.IsLetter(text[i]))
            {
                if (char.IsUpper(text[i]))
                {
                    result += text[i] - 'A';
                }
                else if (char.IsLower(text[i]))
                {
                    result += text[i] - 'a';
                }               
            }
        }
    }
}