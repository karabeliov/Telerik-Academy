using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            string bitsNumber = Convert.ToString(number, 2);
            string reversed = string.Empty;
            
            for (int j = bitsNumber.Length - 1; j >= 0; j--)
            {
                reversed += bitsNumber[j];
            }

            int result = Convert.ToInt32(reversed, 2);
            Console.WriteLine(result);
        }
    }
}