using System;

class NightmareCodeStreet
{
    static void Main()
    {
        string text = Console.ReadLine();
        int counterDigit = 0;
        long sumOfDigit = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (i % 2 != 0)
            {                
                if (Char.IsDigit(text[i]))
                {
                    counterDigit++;
                    sumOfDigit += Convert.ToInt32(text[i].ToString());
                }           
            }
        }

        Console.WriteLine("{0} {1}",counterDigit, sumOfDigit);
    }
}